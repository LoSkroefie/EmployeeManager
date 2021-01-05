using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace EmployeeManager.Controllers
{
 
    public class QueueController : SecurityController
    {
        private Database.QueueQueries QueueQuery = new Database.QueueQueries();
        private Database.QueueRollQueries QueueRollQuery = new Database.QueueRollQueries();
        private Database.EmployeeQueries EmployeeQuery = new Database.EmployeeQueries();
        private Database.TaskQueries TaskQuery = new Database.TaskQueries();


        public IActionResult Index()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Queue/Close"); }
            ViewData["Message"] = "Please Select an Queue to edit, or add a new Queue.";

            List<QueueModel> QueueList = new List<QueueModel>();
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            List<TaskModel> TaskList = new List<TaskModel>();

            EmployeeList = EmployeeQuery.GetEmployees();
            TaskList = TaskQuery.GetTasks();
            QueueList = QueueQuery.GetQueues(QueueList, loggedinEmployee, EmployeeIsAdmin);

            foreach (QueueModel QueueItem in QueueList)
            {
                QueueItem.Employee = EmployeeList.Find(x => x.EmployeeId.Equals(QueueItem.EmployeeId));

                QueueItem.Task = TaskList.Find(x => x.TaskId.Equals(QueueItem.TaskId));
            }


            return View(QueueList);

        }

        public IActionResult List()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Queue/Close"); }
            ViewData["Message"] = "Please Select an Queue to edit, or add a new Queue.";

            List<QueueModel> QueueList = new List<QueueModel>();
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            List<TaskModel> TaskList = new List<TaskModel>();

            EmployeeList = EmployeeQuery.GetEmployees();
            TaskList = TaskQuery.GetTasks();
            QueueList = QueueQuery.GetQueuesJoinedRoll(QueueList, loggedinEmployee, EmployeeIsAdmin);

            foreach (QueueModel QueueItem in QueueList)
            {
                QueueItem.Employee = EmployeeList.Find(x => x.EmployeeId.Equals(QueueItem.EmployeeId));

                QueueItem.Task = TaskList.Find(x => x.TaskId.Equals(QueueItem.TaskId));
            }


            return PartialView("_List", QueueList);

        }
        public IActionResult Close()
        {

            return View();

        }

        public IActionResult Delete(int id)
        {
            QueueQuery.DeleteQueue(id);

            return Redirect("~/Queue/Close");
        }
        public IActionResult Add()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Queue/Close"); }
            ViewData["Message"] = "Please enter the Queue information.";

            QueueModel Queue = new QueueModel();
            Database.EmployeeQueries EmployeeQuery = new Database.EmployeeQueries();
            Database.TaskQueries TaskQuery = new Database.TaskQueries();
            Queue.Employees = EmployeeQuery.GetEmployees();
            Queue.Tasks = TaskQuery.GetTasks();


            return PartialView("_Add", Queue);

        }

        public IActionResult Start(int id)
        {

            ViewData["Message"] = "Please enter the Queue information.";
            QueueModel Queue = new QueueModel
            {
                QueueId = id,
                Employees = EmployeeQuery.GetEmployees(),
                Tasks = TaskQuery.GetTasks()
            };


            return PartialView("_Start", Queue);

        }

        public IActionResult StartQueue(int id)
        {
            QueueRollModel QueueRoll = new QueueRollModel();
            EmployeeModel Employee = new EmployeeModel();
            QueueModel Queue = new QueueModel();
            TaskModel Task = new TaskModel();


            
            Queue = QueueQuery.GetQueue(id);

            Employee = EmployeeQuery.GetEmployee(Queue.EmployeeId);
            Task = TaskQuery.GetTask(Queue.TaskId);

            QueueRoll.QueueId = Queue.QueueId;
            QueueRoll.EmployeeId = Queue.EmployeeId;
            QueueRoll.TaskId = Queue.TaskId;
            QueueRoll.StartDate = DateTime.Now;
            Task.StartDate = QueueRoll.StartDate;
            QueueRoll.Rate = Employee.Rate;

            Task.Status = "Started";
            Task = TaskQuery.UpdateTask(Task);

            QueueRoll = QueueRollQuery.CreateQueueRoll(QueueRoll);

    

          return Redirect("~/Queue/Close");


        }

        public IActionResult CompleteQueue(int id)
        {
            QueueModel Queue = new QueueModel();
            EmployeeModel Employee = new EmployeeModel();
            TaskModel Task = new TaskModel();

            Queue = QueueQuery.GetQueue(id);

            Employee = EmployeeQuery.GetEmployee(Queue.EmployeeId);
            Task = TaskQuery.GetTask(Queue.TaskId);

            Task.Completed = 1;
            Task.DateCompleted = DateTime.Now;

            QueueQuery.UpdateQueueComplete(Queue.QueueId);
            TaskQuery.UpdateTaskComplete(Task);

            // return Redirect("~/Queue/Close");
            return PartialView("Close");

        }
        public IActionResult AddQueue(QueueModel Queue)
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Queue/Close"); }
            ViewData["Message"] = "Please enter the Queue information.";

            Queue = QueueQuery.CreateQueue(Queue);

            return Redirect("~/Queue/Close");


        }
        public IActionResult Edit(int id)
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Queue/Close"); }
            ViewData["Message"] = "Please edit the Queue information.";

            QueueModel Queue = new QueueModel
            {
                QueueId = id,
                Employees = EmployeeQuery.GetEmployees(),
                Tasks = TaskQuery.GetTasks()
            };

     
            Queue = QueueQuery.GetQueue(Queue);


            ViewData["TaskID"] = "Queue ID: " + Queue.QueueId;
          

            return PartialView("_Edit", Queue);
            

        }

        public IActionResult EditQueue(QueueModel Queue)
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Queue/Close"); }
            Queue = QueueQuery.UpdateQueue(Queue);

            return Redirect("~/Queue/Close");

        }

    }
}