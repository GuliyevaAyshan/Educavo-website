using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class CurriculumTitles
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Curriculum> Curriculum { get; set; }
    }
}
