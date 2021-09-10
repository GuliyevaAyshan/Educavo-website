using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMAbout:VMBase
    {
        public About About { get; set; }
        public List<Team> Team { get; set; }
        public List<Events> LatestEvents { get; set; }
        public List<StudentsFeedback> StudentsFeedbacks { get; set; }
        public List<Blog> LatestBlog { get; set; }
        public List<SocialToTeam> SocialToTeam { get; set; }
    }
}
