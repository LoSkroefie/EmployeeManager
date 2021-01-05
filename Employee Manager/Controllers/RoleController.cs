using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace EmployeeManager.Controllers
{
 
    public class RoleController : SecurityController
    {
        private Database.RoleQueries RoleQuery = new Database.RoleQueries();

        public IActionResult Index()
        {

            ViewData["Message"] = "Please Select an Role to edit, or add a new Role.";

            List<RoleModel> RoleList = new List<RoleModel>();


            RoleList = RoleQuery.GetRoles(RoleList);

            return View(RoleList);

        }

        public IActionResult List()
        {

            ViewData["Message"] = "Please Select an Role to edit, or add a new Role.";

            List<RoleModel> RoleList = new List<RoleModel>();


            RoleList = RoleQuery.GetRoles(RoleList);

            return PartialView("_List", RoleList);

        }
        public IActionResult Close()
        {

            return View();

        }


        public IActionResult Add()
        {

            ViewData["Message"] = "Please enter the role information.";

            RoleModel Role = new RoleModel();

            
            return PartialView("_Add", Role);

        }

        public IActionResult AddRole(RoleModel Role)
        {

            ViewData["Message"] = "Please enter the role information.";

            Role = RoleQuery.CreateRole(Role);

           // return Redirect("~/Employee/Add");
            return Redirect("~/Role/Close");


        }
        public IActionResult Edit(int id)
        {
            ViewData["Message"] = "Please edit the role information.";

            RoleModel Role = new RoleModel
            {
                RoleId = id
            };

            Role = RoleQuery.GetRole(Role);


            ViewData["TaskID"] = "Role ID: " + Role.RoleId;
          

            return PartialView("_Edit", Role);
            

        }

        public IActionResult Delete(int id)
        {
            RoleQuery.DeleteRole(id);

            return Redirect("~/Role/Close");
        }
        public IActionResult EditRole(RoleModel Role)
        {

            Role = RoleQuery.UpdateRole(Role);

            return Redirect("~/Role/Close");

        }

    }
}