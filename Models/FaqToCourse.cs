using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class FaqToCourse
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Courses Course { get; set; }
        [ForeignKey("Faq")]
        public int FaqId { get; set; }
        public Faq Faq { get; set; }
    }
}
