using System;

namespace EmployeeManager.Models
{
    public class AccessModel
    {
        //Access Model, contain token and will be handled differently than employee model.
        public bool LoggedIn { get; set; } //Set to true if Log in is successfull
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public int EmployeeId { get; set; }
        public string LoggedInEmployee { get; set; }
        public DateTime LoggedInTimestamp { get; set; }
        public string LoginToken { get; set; } //Created at successfull Login to validate Login Token
    }
}