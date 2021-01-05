using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace EmployeeManager.Controllers
{
   
    public class QueueRollController : SecurityController
    {
        private Database.QueueQueries QueueQuery = new Database.QueueQueries();
        private Database.QueueRollQueries QueueRollQuery = new Database.QueueRollQueries();
        private Database.EmployeeQueries EmployeeQuery = new Database.EmployeeQueries();
        private Database.TaskQueries TaskQuery = new Database.TaskQueries();

        public IActionResult Index()
        {

            ViewData["Message"] = "Please Select a QueueRoll to edit, or add a new QueueRoll.";

            List<QueueRollModel> QueueRollList = new List<QueueRollModel>();
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            List<TaskModel> TaskList = new List<TaskModel>();
            EmployeeList = EmployeeQuery.GetEmployees();
            TaskList = TaskQuery.GetTasks();

            QueueRollList = QueueRollQuery.GetQueuesRoll(QueueRollList, loggedinEmployee, EmployeeIsAdmin);

           // TaskList.Find.First(x => x.Id == idArray).materialId

            foreach (QueueRollModel QueueRollItem in QueueRollList)
            {
                QueueRollItem.Employee = EmployeeList.Find(x => x.EmployeeId.Equals(QueueRollItem.EmployeeId));

                QueueRollItem.Task = TaskList.Find(x => x.TaskId.Equals(QueueRollItem.TaskId));
            }


            return View(QueueRollList);

        }
        public IActionResult List()
        {

            ViewData["Message"] = "Please Select a QueueRoll to edit, or add a new QueueRoll.";

            List<QueueRollModel> QueueRollList = new List<QueueRollModel>();
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            List<TaskModel> TaskList = new List<TaskModel>();
            EmployeeList = EmployeeQuery.GetEmployees();
            TaskList = TaskQuery.GetTasks();

            QueueRollList = QueueRollQuery.GetQueuesRoll(QueueRollList, loggedinEmployee, EmployeeIsAdmin);

            // TaskList.Find.First(x => x.Id == idArray).materialId

            foreach (QueueRollModel QueueRollItem in QueueRollList)
            {
                QueueRollItem.Employee = EmployeeList.Find(x => x.EmployeeId.Equals(QueueRollItem.EmployeeId));

                QueueRollItem.Task = TaskList.Find(x => x.TaskId.Equals(QueueRollItem.TaskId));
            }


            
            return PartialView("_List", QueueRollList);

        }


        public IActionResult Close()
        {

            return View();

        }

        public IActionResult StopQueue(int id)
        {
            QueueRollModel QueueRoll = new QueueRollModel();
            EmployeeModel Employee = new EmployeeModel();

            QueueRoll = QueueRollQuery.GetQueueRoll(id);

            Employee = QueueRoll.Employee;

            QueueRoll.StopDate = DateTime.Now;

            QueueRoll.Minutes = GetMinutes(QueueRoll.StartDate, QueueRoll.StopDate);
            QueueRoll.Rate = Employee.Rate;

            QueueRoll = QueueRollQuery.UpdateQueueRollStop(QueueRoll);

            return PartialView("Close", QueueRoll);
           // return Redirect("~/QueueRoll/Index");


        }

    


        public IActionResult Add()
        {

            ViewData["Message"] = "Please enter the QueueRoll information.";

            QueueRollModel QueueRoll = new QueueRollModel();
           
            return PartialView("_Add", QueueRoll);

        }

        public double GetMinutes(DateTime startdate, DateTime stopdate)
        {

            TimeSpan span = stopdate.Subtract(startdate);

            double totalminutes = span.TotalMinutes;

            return totalminutes;

        }

        public IActionResult AddQueueRoll(QueueRollModel QueueRoll)
        {

            ViewData["Message"] = "Please enter the QueueRoll information.";

            QueueRoll = QueueRollQuery.CreateQueueRoll(QueueRoll);

           // return Redirect("~/Employee/Add");
            return Redirect("~/QueueRoll/Close");


        }
        public IActionResult Edit(int id)
        {
            ViewData["Message"] = "Please edit the QueueRoll information.";

            QueueRollModel QueueRoll = new QueueRollModel
            {
                RollId = id
            };

     
            QueueRoll = QueueRollQuery.GetQueueRoll(QueueRoll);


            ViewData["TaskID"] = "QueueRoll ID: " + QueueRoll.RollId;
          

            return PartialView("_Edit", QueueRoll);
            

        }

        public IActionResult Delete(int id)
        {
            QueueRollQuery.DeleteQueueRoll(id);

            return Redirect("~/QueueRoll/Close");
        }

        public IActionResult EditQueueRoll(QueueRollModel QueueRoll)
        {

            QueueRoll = QueueRollQuery.UpdateQueueRoll(QueueRoll);

            return Redirect("~/QueueRoll/Close");

        }

    }
}