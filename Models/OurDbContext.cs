using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SBDProject.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccont> userAccount { get; set; }

        public DbSet<Friend> friends { get; set; }
    }
}