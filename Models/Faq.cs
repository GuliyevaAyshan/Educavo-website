using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Faq
    {[Key]
        public int Id { get; set; }
        public string Questions { get; set; }
        public string Description { get; set; }
        public List<FaqToCourse> FaqToCourses { get; set; }
        public string Collapse { get; set; }
        [ForeignKey("FaqTitles")]
        public int FaqTitlesId { get; set; }

        public FaqTitles FaqTitles { get; set; }
    }
}
