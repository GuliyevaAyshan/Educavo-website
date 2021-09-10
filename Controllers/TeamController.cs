using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

    
        public IActionResult Index()
        {
            VMTeam model = new VMTeam()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Teams = _context.Team.Include(s => s.SocialToTeam).ThenInclude(st => st.Social).ToList(),
                Socials = _context.Socials.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Contacts = _context.Contacts.ToList()

            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index", "error");
            }
            VMTeam model = new VMTeam()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),          
                Socials = _context.Socials.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Contacts = _context.Contacts.ToList(),      
                Team = _context.Team.Include(c => c.SocialToTeam).ThenInclude(u => u.Social)
                .Include(t=>t.TeamToCourses).ThenInclude(co=>co.Course)
                .Include(cnt=>cnt.ContactToTeam).ThenInclude(t=>t.Contact)
                .Include(s=>s.SkillToTeam).ThenInclude(sk=>sk.Skill)
                .Include(r=>r.Review).FirstOrDefault(b => b.Id == id)
              };
            if (model == null)
            {
                return NotFound();
            }


            return View(model);
        }

    }
}
