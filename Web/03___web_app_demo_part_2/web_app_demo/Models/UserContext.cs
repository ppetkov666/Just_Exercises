using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace web_app_demo.Models
{
    // this class establish the connection to DB
    // the name of the connection string must match the name of this class
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}