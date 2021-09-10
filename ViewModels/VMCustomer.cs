using EduCavoFinal.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMCustomer:VMBase
    {
       
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(250), Required]
        public string Password { get; set; }

        [MaxLength(250)]
        public string ConfirmPassword { get; set; }
        public int? isCommentCourseId { get; set; }
        public int? isCommentInstructorId { get; set; }
        public int? isCommentBlogId { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public List<Customer> Customers { get; set; }
  
    }
}
