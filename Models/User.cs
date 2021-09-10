using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(20), Required]
        public string Surname { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(250), Required]
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string Desc { get; set; }

        [Required]
        public bool IsTeamMember { get; set; }

        [Required]
        public bool Gender { get; set; }
        public DateTime AddedDate { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Courses> Courses { get; set; }
     
    }
}
