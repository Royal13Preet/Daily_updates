using Adding_migration;
using Adding_migration.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

class Program
{
    public static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {

            //var student = new Student
            //{

            //    StudentName = "preet",
            //    StudentGender = "female",
            //    StudentAge = 54,
            //    StudebtDoB = new DateTime(2003, 1, 1),
            //    StudentPhone = 929292929
            //};
            //context.Teachers.Add(new Teacher
            //{
            //    Name = "preet",
            //    email = "kofgu@hhj",
            //    phone = 5333535
            //});
            //context.Students.Add(student);
            //Student s = new Student();
            //Console.WriteLine("Enter the student Name");
            //s.StudentName = Console.ReadLine();
            //Console.WriteLine("Enter the student Gender");
            //s.StudentGender = Console.ReadLine();
            //Console.WriteLine("Enter the student Age");
            //s.StudentAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the student DOB");
            //s.StudebtDoB = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Enter a Phone number");
            //s.StudentPhone = Convert.ToInt32(Console.ReadLine());


            //context.Students.Add(s);

            Console.WriteLine("DB status after getting data");
            var student = context.Students.FirstOrDefault();
            //Console.WriteLine(student.StudentName);
            DisplayState(context.ChangeTracker.Entries());

            var student1 = new Student
            {

                StudentName = "siddaraju",
                StudentGender = "male",
                StudentAge = 23,
                StudebtDoB = new DateTime(2003, 1, 1),
                StudentPhone = 6856994,
                courseId = 1
            };

           
            context.Students.Add(student1);
            Console.WriteLine("DB status after adding data");
            DisplayState(context.ChangeTracker.Entries());
            context.SaveChanges();
        }


    }

        public static void DisplayState(IEnumerable<EntityEntry> entities)
        {
            foreach (var entity in entities)
            {
                Console.WriteLine($"Entity : {entity.Entity.GetType().Name}, State: {entity.State}");
            }
        

        }
    }
