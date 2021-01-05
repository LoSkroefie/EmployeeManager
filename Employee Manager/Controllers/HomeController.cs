using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeManager.Models;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeManager.Controllers
{
   
    public class HomeController : SecurityController
    {

        private Database.QueueQueries QueueQuery = new Database.QueueQueries();
        private Database.QueueRollQueries QueueRollQuery = new Database.QueueRollQueries();
        private Database.EmployeeQueries EmployeeQuery = new Database.EmployeeQueries();
        private Database.TaskQueries TaskQuery = new Database.TaskQueries();
        private Database.AccessQueries AccessQuery = new Database.AccessQueries();
        private AccessModel Access = new AccessModel();

        public IActionResult Index()
        {
            
           

            HomeModel HomeLists = new HomeModel();
            List<QueueRollModel> QueueRollList = new List<QueueRollModel>();
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            List<TaskModel> TaskList = new List<TaskModel>();
            EmployeeList = EmployeeQuery.GetEmployees();
            TaskList = TaskQuery.GetTasks();

            QueueRollList = QueueRollQuery.GetQueuesRoll(QueueRollList,loggedinEmployee,EmployeeIsAdmin);

            foreach (QueueRollModel QueueRollItem in QueueRollList)
            {
                QueueRollItem.Employee = EmployeeList.Find(x => x.EmployeeId.Equals(QueueRollItem.EmployeeId));

                QueueRollItem.Task = TaskList.Find(x => x.TaskId.Equals(QueueRollItem.TaskId));
            }

            HomeLists.ActiveTasks = QueueRollList;



            ViewData["Message"] = "Please Select a queue to edit, or add a new queue.";

            List<QueueModel> QueueList = new List<QueueModel>();
          
            QueueList = QueueQuery.GetQueuesJoinedRoll(QueueList, loggedinEmployee, EmployeeIsAdmin);

            foreach (QueueModel QueueItem in QueueList)
            {
                QueueItem.Employee = EmployeeList.Find(x => x.EmployeeId.Equals(QueueItem.EmployeeId));

                QueueItem.Task = TaskList.Find(x => x.TaskId.Equals(QueueItem.TaskId));
            }

            HomeLists.AvailableTasks = QueueList;
            HomeLists.EmployeeIsAdmin = EmployeeIsAdmin;
            if (loggedinEmployee > 0)
            {
                HomeLists.LoggedIn = true;
            } else {
                HomeLists.LoggedIn = false;
            }
           

            return View(HomeLists);
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
