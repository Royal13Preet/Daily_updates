﻿using AddingMigration.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingMigration
{
    public class SchollContect : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SchoolDB;Trusted_Connection=True;Integrated Security=True;Encrypt=false;");
        }
    }
}
