using APIwithEntityFrameworkcore.DBModels;
using Microsoft.EntityFrameworkCore;

namespace APIwithEntityFrameworkcore.Context
{
    public class SchoolContext : DbContext
    {
        IConfiguration Configuration { get; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public SchoolContext(IConfiguration configuration)
        {
            Configuration = configuration;

        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Course>(s => s.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.courseId);
            
            // cong=figure default values for student
            modelBuilder.Entity<Student>()
                .Property(s => s.dateAdd)
                .HasDefaultValueSql("getdate()");
        }
    }
}
