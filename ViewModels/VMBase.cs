using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMBase
    {
        public List<Blog> RecentPosts { get; set; }
        public List<Social> Socials { get; set; }
        public List<Contact> Contacts { get; set; }
        public Subscribe Subscribe { get; set; }
        public List<Sliders> Sliders { get; set; }
    }
}
