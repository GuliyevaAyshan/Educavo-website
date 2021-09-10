using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMFaq:VMBase
    {
        public List<Faq> Faqs { get; set; }
        public List<FaqToCourse> FaqToCourses { get; set; }
        public List<FaqTitles> FaqTitles { get; set; }
    }
}
