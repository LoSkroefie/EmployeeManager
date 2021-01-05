using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class RoleModel
    {
        
        [Display(Name = "Role ID")]
        public int RoleId { get; set; }

        [Display(Name = "Role Description")]
        public string Description { get; set; }

        [Display(Name = "Role Rate")]
        public decimal Rate { get; set; }
        

    }
}