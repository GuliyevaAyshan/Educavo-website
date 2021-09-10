using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCavoFinal.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]

        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        public string Username { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        [MaxLength(15), Required, NotMapped]
        public string PasswordInput { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        public bool HasAccount { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        public DateTime AddedDate { get; set; }
        public string Token { get; internal set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Courses> Courses { get; set; }
   
    
    }
}
