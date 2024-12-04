using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PracticeEf;
using PracticeEf.Models;

public class Program
{
    public static void Main(string[] args)
    {
        using (var context = new Schoolcontext())
        {
            var student = new Student
            {
                Id = 4,
                StudentName = "preet",
                StudentEmail = "ps@gmail.com",
                StudentPhone = 990220474,
                StudentDOB = new DateTime(2004,9,8)


            };
            var teacher = new Teacher
            {
                
                TeacherName = "Test",
                Description = "khfru"
                
            };

            
            //Console.WriteLine("DBContext before changing");
            //var students = context.students.FirstOrDefault();
            //DisplayState(context.ChangeTracker.Entries());

            context.students.Attach(student);
            
            context.SaveChanges();
            context.teachers.Add(teacher);

            Console.WriteLine("DBcontext after changing");
            DisplayState(context.ChangeTracker.Entries());
            context.SaveChanges();

        }
    }
    private static void DisplayState(IEnumerable<EntityEntry> entries)
    {
        foreach(var entity in entries)
        {
            Console.WriteLine($"Entity; {entity.Entity.GetType().Name}, State: {entity.State}");
        }

    }

    
}

