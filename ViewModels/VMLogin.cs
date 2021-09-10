using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMLogin : VMBase
    {
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(30)]
        public string Password { get; set; }
    }
}