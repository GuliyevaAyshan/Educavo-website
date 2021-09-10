using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class DurationTime
    {[Key]
        public int Id { get; set; }
        public string Times { get; set; }
        public List<Courses> Course{ get; set; }
    }
}
