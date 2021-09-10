using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        [NotMapped]      
        public IFormFile ImageFile { get; set; }
        public int OnlineCategoriesCount { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Courses> Courses { get; set; }
        public bool IsOnline { get; set; }
        public List<ErrorPage> Errors { get; set; }
    }
}
