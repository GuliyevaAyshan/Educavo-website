using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMBlog : VMBase
    {
        public Blog Blog { get; set; }
        public IList<Blog> Blogs { get; set; }
        public List<Blog> RecentPost { get; set; }
        public List<Blog> BlogArchives { get; set; }
        public List<Blog> RelatedBlogs { get; set; }
        public List<Categories> Categories { get; set; }
        public List<User> Users { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment Comment { get; set; }
        public List<VMDate> VMDates { get; set; }

    }
}