using Microsoft.EntityFrameworkCore;
using Migrate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Migrate
{
    public class SchoolContext : DbContext
    {
        public DbSet<student> Students {  get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=PREETHU_GSS\MSSQLSERVER02; Database = SchoolDB; Trusted_Connection=True; Integrated Security = True; Encrypt = false;");
        }
    }
    
    
}
