using EmployeeManager.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Web;


namespace EmployeeManager.Controllers
{

    public class EmployeeController : SecurityController
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        private Database.AccessQueries AccessQuery = new Database.AccessQueries();
        private Database.EmployeeQueries EmployeeQuery = new Database.EmployeeQueries();
        private Database.RoleQueries RoleQuery = new Database.RoleQueries();

        public IActionResult Index()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Employee/Close"); }
            ViewData["Message"] = "Please Select an employee to edit, or add a new employee.";

            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();


            EmployeeList = EmployeeQuery.GetEmployees(EmployeeList);

            return View(EmployeeList);

        }

        public IActionResult List()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Employee/Close"); }
            ViewData["Message"] = "Please Select an employee to edit, or add a new employee.";

            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();

            EmployeeList = EmployeeQuery.GetEmployees(EmployeeList);

            return PartialView("_List", EmployeeList);

        }


        public IActionResult Close(TaskModel Task)
        {

            return View(Task);

        }


        public IActionResult Add()
        {
            if (EmployeeIsAdmin == false) { return Redirect("~/Employee/Close"); } //check if logged in if user tries to access page directly.

            ViewData["Message"] = "Please enter the employee information."; //set the data for the view.

            EmployeeModel Employee = new EmployeeModel(); //create a new model for the employee to be created. This object is reused.

            Employee.Roles = RoleQuery.GetRoles(); // set a list the roles model to the employee model this makes it available in the view.


            return PartialView("_Add", Employee); //return the view to display

        }

  
        public IActionResult AddEmployee(EmployeeModel Employee, IFormFile postedFile)
        {

            if (postedFile != null) // check if a file was uploaded.
            {
                // set the paths needed for the upload
                string wwwPath = _hostingEnvironment.WebRootPath; 
                string contentPath = _hostingEnvironment.ContentRootPath;

                string path = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads"); // generate a complete path to save the files
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path); // create the directory if it doesnt exist.
                }
                // create a new filename for the uploaded file
                string fileName = Employee.EmployeeId.ToString() + Path.GetFileName(postedFile.FileName).Substring(postedFile.FileName.IndexOf("."), 4);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream); //save the file stream to the saved file.
                }
                Employee.Photo = fileName; //set the filename value in the employee model
            }

            Employee.Rate = RoleQuery.GetRoleRate(Employee.Level); // determine the rate from the dropdown selected role

            Employee = EmployeeQuery.CreateEmployee(Employee); //create employee from the object.

            AccessModel access = new AccessModel(); //create a new access model to be created in the access table
            access.Username = Employee.Username; //set username
            access.Password = Employee.Password; //set password
            access.IsAdmin = Employee.IsAdmin; // set administrator flag
            access.EmployeeId = Employee.EmployeeId; //save the employee id to tie the access record to the employee record.

            AccessQuery.CreateUser(access); //create the user in the access table.


            return Redirect("~/Employee/Close"); //redirect to a close script to automatically close the window.


        }
        public IActionResult Edit(int id)
        {
         //set view data to be displayed
            ViewData["Message"] = "Please edit the employee information.";
            //create new employee model to pass along
            EmployeeModel Employee = new EmployeeModel
            {
                EmployeeId = id,//set model ID
                Roles = RoleQuery.GetRoles() //Set Roles model list to employee model to make it available in the view
        };
            Employee.Fullname = Employee.Name + " " + Employee.Lastname; //set full names in the model

            Employee = EmployeeQuery.GetEmployee(Employee); //get employee information from the database, we pass the model to the function

            ViewData["TaskID"] = "Task ID: " + Employee.EmployeeId; //set viewdata

            return PartialView("_Edit", Employee); //return edit view
        }

        public IActionResult Delete(int id)
        {
             EmployeeQuery.DeleteEmployee(id); //call delete function

            return Redirect("~/Employee/Close"); //call close script to close the window.
        }
        public IActionResult EditEmployee(EmployeeModel Employee, IFormFile postedFile)
        {
            if (postedFile != null) //check if a photo was uploaded
            {
                //set upload paths
                string wwwPath = _hostingEnvironment.WebRootPath;
                string contentPath = _hostingEnvironment.ContentRootPath;
                //combine path to get full upload directory
                string path = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path); //if folder does not exist, create it.
                }

                //set new filename
                string fileName = Employee.EmployeeId.ToString() + Path.GetFileName(postedFile.FileName).Substring(postedFile.FileName.IndexOf("."), 4);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream); //write file stream 
                  
                }

                Employee.Photo = fileName; //set filename to model properties
            }

            //create access model to save to access table
            AccessModel access = new AccessModel();
            access.Username = Employee.Username;
            access.Password = Employee.Password;
            access.IsAdmin = Employee.IsAdmin;
            access.EmployeeId = Employee.EmployeeId;

            AccessQuery.UpdateUser(access); //save user info


            Employee.Rate = RoleQuery.GetRoleRate(Employee.Level); //get employee rate
            Employee = EmployeeQuery.UpdateEmployee(Employee); //save the employee information to database

            return Redirect("~/Employee/Close"); //run close script to close window automatically

        }

        public EmployeeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
           

        }

    }
}