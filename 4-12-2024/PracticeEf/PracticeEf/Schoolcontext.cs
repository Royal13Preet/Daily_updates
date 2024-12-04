using Microsoft.EntityFrameworkCore;
using PracticeEf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEf
{
    public class Schoolcontext : DbContext
    {
       public DbSet<Student> students {  get; set; }

        public DbSet<Course> courses { get; set; }

        public DbSet<Teacher> teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =PREETHU_GSS\MSSQLSERVER02; Database = PracticeDB; Trusted_Connection = true; Integrated Security = True; Encrypt = false; ");
        }
    }
}
