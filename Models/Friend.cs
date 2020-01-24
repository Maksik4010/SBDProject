using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SBDProject.Models
{
    public class Friend
    {
        [Key]
        public int Id_znajomi { get; set; }
        public int Id_uzytkownicy { get; set; }
        public UserAccont user { get; set; }
        public int Id_znajomwgo { get; set; }
        public int poczatek_znajomosci { get; set; }
    }
}