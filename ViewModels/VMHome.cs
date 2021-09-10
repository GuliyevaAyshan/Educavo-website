using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMHome:VMBase
    {
        //public List<Sliders> Sliders { get; set; }
        public List<Courses> PopularCourses { get; set; }
        public List<Testimonials> Testimonials { get; set; }
        public List<Blog> LatestBlog { get; set; }
        public List<Categories> PopularCategories { get; set; }
        public List<Categories> ViewAllCategories { get; set; }
        public List<Faq> MostAskedFaqs { get; set; }
        public List<OfferState> OfferStates { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
