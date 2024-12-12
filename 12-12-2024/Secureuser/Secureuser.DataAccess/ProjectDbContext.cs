using Microsoft.EntityFrameworkCore;
using Secureuser.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Secureuser.DataAccess
{
    public class ProjectDbContext : DbContext
    {
        
       
            public DbSet<User> users { get; set; }

            public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        Username = "Preet@gmail.com",
                        Password = "Preet@123",
                        Role = "admin"
                    },
                       new User
                       {
                           Id = 2,
                           Username = "khushi@gmail.com",
                           Password = "khushi@123",
                           Role = "user"
                       }


                );
            }
        }
    }

