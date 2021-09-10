using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Video { get; set; }
        [NotMapped]
        public IFormFile VideoFile { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Students { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CGPA { get; set; }
        public int Graduates { get; set; }
    }
}
