using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class PriceLevel
    {[Key]
        public int Id { get; set; }
        public string Levels { get; set; }
        public List<Courses> Courses { get; set; }
    }
}
