using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(60)]
        public string FullName { get; set; }

        [MaxLength(100)]
        public string Position { get; set; }

        [MaxLength(500)]
        public string Info { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<SkillToTeam> SkillToTeam { get; set; }
        public List<SocialToTeam> SocialToTeam { get; set; }
        public List<TeamToCourses> TeamToCourses { get; set; }
        public List<ContactToTeam> ContactToTeam { get; set; }
        public List<Review> Review { get; set; }
        public int TotalStudent { get; set; }
        public int TotalRating { get; set; }
        public string TeamOvercoming { get; set; }
    }
}
