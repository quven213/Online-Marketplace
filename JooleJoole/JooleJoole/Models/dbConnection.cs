using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JooleJoole.Models
{
    public class dbConnection : DbContext
    {
        public DbSet<Users> Users { get; set; }
    }
}