using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }

        public string Icon { get; set; }
        public List<SocialToTeam> SocialToTeam { get; set; }
    }
}
