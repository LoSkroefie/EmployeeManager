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
   
    public class FeedsController : SecurityController
    {
        
        private Database.FeedsQueries FeedsQuery = new Database.FeedsQueries();

        public IActionResult Index(List<FeedsModel> Feeds)
        {
           // List<FeedsModel> Feeds = new List<FeedsModel>();

            Feeds = FeedsQuery.getFeeds(Feeds);
            Feeds = fixNames(Feeds);


         Feeds = FeedsQuery.UpdateFeeds(Feeds);

            ViewData["Message"] = "Please log in to continue.";
            return View(Feeds);


        }

  
    private List<FeedsModel> fixNames(List<FeedsModel> feeds)
        {
            foreach (FeedsModel feed in feeds)
            {
                if (feed.Link_Name.Contains("|"))
                {

                    string[] splitName = feed.Link_Name.Split('|');
                    string newname = splitName[1];
                    feed.Link_Name = newname.Trim();

                }
            }
            return feeds;
        }
   

    }
}