using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DejtingSajt.Models
{
    public class UserDbContext : DbContext  {
        public DbSet<User> Users { get; set; }
        public UserDbContext() : base("userdb") { }
    }
}