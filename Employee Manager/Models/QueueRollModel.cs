using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class QueueRollModel
    {
        //rollid, queueid, employeeid, taskid, startdate, stopdate, minutes, rate
        [Display(Name = "Roll ID")]
        public int RollId { get; set; }

        [Display(Name = "Queue ID")]
        public int QueueId { get; set; }

        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Task ID")]
        public int TaskId { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Stop Date")]
        public DateTime StopDate { get; set; }

        [Display(Name = "Minutes")]
        public double Minutes { get; set; }

        [Display(Name = "Rate")]
        public decimal Rate { get; set; }

        
        public EmployeeModel Employee { get; set; }

        public TaskModel Task { get; set; }
    }
}