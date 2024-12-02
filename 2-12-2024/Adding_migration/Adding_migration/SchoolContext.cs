using Adding_migration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_migration
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SchoolDB;Trusted_Connection=True;Integrated Security=True;Encrypt=false;");
        }

        //seed data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(new Course { Id = 1, Name = "Maths", description = "Mathematics1" });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 2, Name = "Scien", description = "Science" });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 3, Name = "SocialScience", description = "Social" });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 4, Name = "C#", description = "C#" });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id = 1,
                Name = "john doe",
                email = "psre@gmail.com",
                phone = 79658590
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 1,
                StudentName = "pss",
                StudentGender = "male",
                StudentAge = 30,
                StudebtDoB = new DateTime(2002, 9, 4),
                StudentPhone = 894634302,
                courseId = 1

            });
        }

    }
}
