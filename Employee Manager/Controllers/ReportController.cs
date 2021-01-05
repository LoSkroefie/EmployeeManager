using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace EmployeeManager.Controllers
{
 
    public class ReportController : SecurityController
    {
        private Database.QueueRollQueries QueueRollQuery = new Database.QueueRollQueries();
        private Database.EmployeeQueries EmployeeQuery = new Database.EmployeeQueries();
        private Database.TaskQueries TaskQuery = new Database.TaskQueries();
        private Database.ReportQueries ReportQuery = new Database.ReportQueries();
        public IActionResult Index()
        {

            ViewData["Message"] = "Please Select an employee and specify a daterange to generate the report.";

            ReportModel Report = new ReportModel();
         
            Report.Employees = EmployeeQuery.GetEmployees();

            return View(Report);

        }
        public IActionResult List()
        {
            
            ViewData["Message"] = "Please Select an employee and specify a daterange to generate the report.";

            ReportModel Report = new ReportModel();

            Report.Employees = EmployeeQuery.GetEmployees();
            Report.IsAdmin = EmployeeIsAdmin;
            if (EmployeeIsAdmin)
            {
                Report.EmployeeId = loggedinEmployee;
            }
            
            return PartialView("_List", Report);

        }

       
        public IActionResult RunReport(ReportModel Report)
        {

            ViewData["Message"] = "Please Select a QueueRoll to edit, or add a new QueueRoll.";

            List<ReportModel> ReportList = new List<ReportModel>();
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            List<TaskModel> TaskList = new List<TaskModel>();
            EmployeeList = EmployeeQuery.GetEmployees();
            TaskList = TaskQuery.GetTasks();
            if (!EmployeeIsAdmin)
            {
                Report.EmployeeId = loggedinEmployee;
            }
            ReportList = ReportQuery.GetReport(ReportList, Report.EmployeeId, Report.ReportStartDate, Report.ReportEndDate);



            foreach (ReportModel ReportItem in ReportList)
            {
                ReportItem.Employee = EmployeeList.Find(x => x.EmployeeId.Equals(ReportItem.EmployeeId));

                ReportItem.Task = TaskList.Find(x => x.TaskId.Equals(ReportItem.TaskId));
            }

            ReportList = CalculateReport(ReportList);
            ViewData["GrandTotal"] = ReturnReportTotal(ReportList);
            return PartialView("RunReport", ReportList);
            

        }



        public List<ReportModel> CalculateReport(List<ReportModel> ReportList)
        {
         

            foreach (ReportModel reportItem in ReportList)
            {
                
                double HoursWorked = reportItem.Minutes / 60;
                decimal Total = reportItem.Rate * (decimal)HoursWorked;
                string totalround = Convert.ToDecimal(Total).ToString("#,##0.00"); 
                reportItem.Total = decimal.Parse(totalround);
          


            }

            return ReportList;
        }
        public decimal ReturnReportTotal(List<ReportModel> ReportList)
        {
            decimal GrandTotal = 0;

            foreach (ReportModel reportItem in ReportList)
            {
                
                double HoursWorked = reportItem.Minutes / 60;
                decimal Total = reportItem.Rate * (decimal)HoursWorked;
                string totalround = Convert.ToDecimal(Total).ToString("#,##0.00");
                reportItem.Total = decimal.Parse(totalround);
                GrandTotal = GrandTotal + decimal.Parse(totalround);
                // reportItem.GrandTotal = GrandTotal;



            }

            return GrandTotal;
        }



        public double GetMinutes(DateTime startdate, DateTime stopdate)
        {

            TimeSpan span = stopdate.Subtract(startdate);

            double totalminutes = span.TotalMinutes;

            return totalminutes;

        }


    }
}