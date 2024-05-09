using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame
{
    public class AppContext : DbContext
    {
        // Объекты такблицы users
        public DbSet<User> Users { get; set; }
        public AppContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TestDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
