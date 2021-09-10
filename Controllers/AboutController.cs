using EduCavoFinal.Data;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VMAbout model = new VMAbout()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                About = _context.About.FirstOrDefault(),               
                Team= _context.Team.Include(s => s.SocialToTeam).ThenInclude(st => st.Social).OrderBy(o => o.FullName).Take(6).ToList(),
                SocialToTeam = _context.SocialToTeams.Include(s => s.Team).Take(4).ToList(),
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.ToList(),
                StudentsFeedbacks = _context.StudentsFeedbacks.ToList(),
                LatestBlog = _context.Blog.Include(u => u.Users).OrderByDescending(i=>i.AddedDate).Take(2).ToList(),
                LatestEvents = _context.Events.Take(4).ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault()
            };
            if (model==null)
            {
                return View("index", "error");
            }
            return View(model);
        }
    }
}
