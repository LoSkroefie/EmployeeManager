using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace EmployeeManager.Controllers
{
    
    public class TaskController : SecurityController
    {
        private Database.TaskQueries TaskQuery = new Database.TaskQueries();

        public IActionResult Index()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Task/Close"); }
            ViewData["Message"] = "Please Select a task to edit, or add a new task.";
           
            List<TaskModel> TaskList = new List<TaskModel>();


            TaskList = TaskQuery.GetTasks(TaskList);
            return View(TaskList);

        }

        public IActionResult List()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Task/Close"); }
            ViewData["Message"] = "Please Select a task to edit, or add a new task.";

            List<TaskModel> TaskList = new List<TaskModel>();


            TaskList = TaskQuery.GetTasks(TaskList);
           
            return PartialView("_List", TaskList);

        }

        public IActionResult Add(TaskModel Task)
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Task/Close"); } //check if admin
            ViewData["Message"] = "Please enter the task information."; //set viewdata info

            Task.DateCreated = DateTime.Now; //set create timestamp

            return PartialView("_Add", Task); //show view

        }



        public IActionResult AddTask(TaskModel Task)
        {
            Task.Status = "Created"; //set task status to created
            Task = TaskQuery.CreateTask(Task); //call create function

            return Redirect("~/Task/Close"); //call script to close window automatically

        }

        public IActionResult Close()
        {

            return View();

        }


        public IActionResult Edit(int id)
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Task/Close"); } //check if admin
            ViewData["Message"] = "Please edit the task information."; //set viewdata information

            TaskModel Task = new TaskModel //create a new task model
            {
                TaskId = id //set the id passed into action
            };

            Task = TaskQuery.GetTask(Task); //get the task data

            ViewData["TaskID"] = "Task ID: " + Task.TaskId; //set view data
            ViewData["Created"] = "Task Created: " + Task.DateCreated.ToShortDateString();

            return PartialView("_Edit", Task); //return the view

        }

        public IActionResult Delete(int id)
        {
            TaskQuery.DeleteTask(id); //call delete query

            return Redirect("~/Task/Close");//call  script to automatically close the window
        }

        public IActionResult EditTask(TaskModel Task)
        {

            Task = TaskQuery.UpdateTask(Task); //save task info to database

            return Redirect("~/Task/Close"); //call  script to automatically close the window

        }

     


   


    }
}