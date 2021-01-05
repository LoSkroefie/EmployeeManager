using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace EmployeeManager.Models
{

    public class EmployeeModel
    {
        
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Display(Name = "Employee Lastname")]
        public string Lastname { get; set; }

        [Display(Name = "Employee Fullname")]
        public string Fullname { get; set; }

        [Display(Name = "Employee ID Number")]
        public string IDNumber { get; set; }

        [Display(Name = "Employee Address")]
        public string Address { get; set; }

        [Display(Name = "Employee Phone")]
        public string Phone { get; set; }

        [Display(Name = "Employee Level")]
        public int Level { get; set; }

        [Display(Name = "Employee Rate")]
        public decimal Rate { get; set; }

        [Display(Name = "Employee Photo")]
        public string Photo { get; set; }


        [Display(Name = "Employee Roles")]
        public List<RoleModel> Roles { get; set; }

        //Employee Login Info
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

    }
}