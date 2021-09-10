using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMTeam:VMBase
    {
        public Team Team { get; set; }
        public List<Team> Teams { get; set; }
        public List<SocialToTeam> SocialToTeam { get; set; }
        public List<ContactToTeam> ContactToTeam { get; set; }
        public List<TeamToCourses> TeamToCourses { get; set; }
        public List<Review> Review { get; set; }
        public List<SkillToTeam> SkillToTeam { get; set; }
    }
}
