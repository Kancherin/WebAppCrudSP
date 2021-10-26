using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCrudSP.Web.Models;

namespace WebAppCrudSP.Web.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Server=david-pc;Database=School;Trusted_Connection=True;MultipleActiveResultSets=True");
            options.UseSqlServer(connectionString);
        }

        public DbSet<Student> Students { get; set; }
    }
}
