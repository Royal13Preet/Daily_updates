using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEf.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }

        public string StudentEmail { get; set; }

        public int StudentPhone { get; set; }

        public DateTime StudentDOB { get; set; }



    }
}
