using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_migration.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public int StudentAge { get; set; }
        public DateTime StudebtDoB { get; set; }
        public int StudentPhone { get; set; }

        [ForeignKey("courseId")]
        public int courseId { get; set; }
        public Course course { get; set; }
    }
}
