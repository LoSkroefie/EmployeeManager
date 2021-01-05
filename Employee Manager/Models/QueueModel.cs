using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class QueueModel
    {
    

        [Display(Name = "Queue ID")]
        public int QueueId { get; set; }

        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Task ID")]
        public int TaskId { get; set; }
        
        public List<EmployeeModel> Employees { get; set; }

        public List<TaskModel> Tasks { get; set; }

        public EmployeeModel Employee { get; set; }

        public TaskModel Task { get; set; }


    }
}