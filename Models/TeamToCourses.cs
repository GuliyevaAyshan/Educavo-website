using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class TeamToCourses
    {[Key]
        public int Id { get; set; }
        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Team { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Courses Course { get; set; }
    }
}
