using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class HomeModel
    {
        
        public bool EmployeeIsAdmin { get; set; }
        public bool LoggedIn { get; set; }
        public List<QueueModel> AvailableTasks { get; set; }
        public List<QueueRollModel> ActiveTasks { get; set; }



    }
}