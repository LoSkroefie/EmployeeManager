using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class TaskModel
    {

        [Display(Name = "Task ID")]
        public int TaskId { get; set; }

        [Display(Name = "Task Title")]
        public string Title { get; set; }

        [Display(Name = "Task Description")]
        public string Description { get; set; }

        [Display(Name = "Task Status")]
        public string Status { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Date Completed")]
        public DateTime DateCompleted { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        public int Completed { get; set; }
    }

    public enum Task_Status
    {
        None,
        Started,
        Overdue,
        Completed,
        Closed
    }
}