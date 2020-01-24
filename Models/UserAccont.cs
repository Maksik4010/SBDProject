using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SBDProject.Models
{
    public class UserAccont
    {
        [Key]
        public int UserID { get; set; }
       
        [Required(ErrorMessage ="Username is required. ")]
        public string Username { get; set; }
       
        [Required(ErrorMessage = "Password is required. ")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "FirstName is required. ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required. ")]
        public string LastName { get; set; }
       
        [Required(ErrorMessage = "Login is required. ")]
        public string Login { get; set; }
        public int CreateData { get; set; }
        public int LastLogin { get; set; }
        public int ipLastLogin { get; set; }
        
        [Required(ErrorMessage = "Country is required. ")]
        public string Country { get; set; }
        public int FrindsNumber { get; set; }
    }
}