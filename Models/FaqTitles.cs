using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class FaqTitles
    {[Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Faq> Faq { get; set; }
    }
}
