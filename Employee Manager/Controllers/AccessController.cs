using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Controllers
{
    public class SecurityController : Controller
    {
        public string accessToken = "";
        public int loggedinEmployee = 0;
        public bool EmployeeIsAdmin = false;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            Database.AccessQueries AccessQuery = new Database.AccessQueries();
            AccessModel Access = new AccessModel();

            Access.LoginToken = HttpContext.Session.GetString("AccessToken");
            Access.Username = HttpContext.Session.GetString("Username");
            accessToken = Access.LoginToken;

            Access = AccessQuery.VerifyTokenData(Access, Access.Username, Access.LoginToken);

            if (Access.LoggedIn == false)
            {
                if (!filterContext.Controller.ToString().Contains("AccessController"))
                {
                    Response.Redirect("Access/");
                }

            }
            else
            {
                EmployeeIsAdmin = Access.IsAdmin;
                loggedinEmployee = Access.EmployeeId;
               // Response.Redirect("Home/");
            }
           

        }
    }
    public class AccessController : SecurityController
    {
        public AccessModel SessionAccess = new AccessModel();
        private Database.AccessQueries AccessQuery = new Database.AccessQueries();

        public IActionResult Index(AccessModel AccessToken)
        {
         
            if (!string.IsNullOrEmpty(AccessToken.Username)) {

                AccessToken = VerifyAccess(AccessToken);

                if (AccessToken.LoggedIn)
                {
                    AccessQuery.UpdateToken(AccessToken);

                    HttpContext.Session.SetString("AccessToken", AccessToken.LoginToken);
                    HttpContext.Session.SetString("Username", AccessToken.Username);

                    return Redirect("~/Home/");

                } else
                {
                   return  Redirect("~/Access/");

                }
 
            }

            ViewData["Message"] = "Please log in to continue.";
            return View();


        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("AccessToken", "");
            HttpContext.Session.SetString("Username", "");

                    return Redirect("~/Access/");
 
        }

  
        private AccessModel VerifyAccess(AccessModel AccessToken)
        {
           
            AccessToken = AccessQuery.getLoginData(AccessToken);

            if (AccessToken.LoggedIn)
            {
                AccessToken.LoggedInTimestamp = DateTime.Now;
                AccessToken.LoginToken = GenerateToken();
            } else
            {
                AccessToken.LoggedInTimestamp = DateTime.MinValue;
                AccessToken.LoginToken = "";
            }
            return AccessToken;
        }

        public string GenerateToken()
        {
           
            var allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var resultToken = new string(
               Enumerable.Repeat(allChar, 8)
               .Select(token => token[random.Next(token.Length)]).ToArray());

            string authToken = resultToken.ToString();


            return authToken;
        }


        

    }
}