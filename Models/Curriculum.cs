using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Curriculum
    {[Key]
        public int Id { get; set; }
        public string Subtitle { get; set; }
        public string Video { get; set; }    
        [NotMapped]
        public IFormFile VideoFile { get; set; }
        public string VideoDuration { get; set; }
        [ForeignKey("Courses")]
        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
        public string Collapse { get; set; }
        [ForeignKey("CurriculumTitles")]
        public int CurriculumTitlesId { get; set; }

        public CurriculumTitles CurriculumTitles { get; set; }
    }
}
