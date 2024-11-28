using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrate.Model
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }

    }
}
