using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrate.Model
{
    public class student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public int StudentAge { get; set; }
        public DateTime StudebtDoB { get; set; }
        public int StudentPhone { get; set; }
    }
}
