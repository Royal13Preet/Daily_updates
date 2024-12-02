using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIwithEntityFrameworkcore.DBModels
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public string StudentAddress { get; set; }

        public string StudentEmail { get; set; }

        public DateTime StudebtDoB { get; set; }
        public string StudentGender { get; set; }

        public DateTime dateAdd { get; set; }
       
        //Navigating property
        //a student can have only one course 1:1

        public int courseId;
        public Course Course { get; set; }


    }
}
