using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMContact:VMBase
    {
        public List<Message> Messages { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Surname { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        public string Subject { get; set; }
        [Required, MaxLength(500)]
        public string MessageText { get; set; }
        public int customerId { get; set; }
    }
}
