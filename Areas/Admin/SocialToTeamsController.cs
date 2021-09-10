using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.Filters;

namespace EduCavoFinal.Areas.Admin
{
    [Area("Admin")]
    [AuthUser]
    public class SocialToTeamsController : Controller
    {
        private readonly AppDbContext _context;

        public SocialToTeamsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SocialToTeams
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.SocialToTeams.Include(s => s.Social).Include(s => s.Team);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/SocialToTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialToTeam = await _context.SocialToTeams
                .Include(s => s.Social)
                .Include(s => s.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialToTeam == null)
            {
                return NotFound();
            }

            return View(socialToTeam);
        }

        // GET: Admin/SocialToTeams/Create
        public IActionResult Create()
        {
            List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
            socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
            ViewBag.Social = socialid;
            List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;
            return View();
        }

        // POST: Admin/SocialToTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SocialToTeam model)
        {
            if (ModelState.IsValid)
            {
                if (model.SocialId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("SocialId", "You must select any social");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
                    socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
                    ViewBag.Social = socialid;
                    List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;

                    return View(model);
                }
                if (model.SocialId == 0)
                {
                    ModelState.AddModelError("SocialId", "You must select any social");
                    List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
                    socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
                    ViewBag.Social = socialid;
                    return View(model);
                }
                if (model.TeamId == 0)
                {
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;

                    return View(model);
                }

                else //if no photo
                {
                    _context.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }


        // GET: Admin/SocialToTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialToTeam = await _context.SocialToTeams.FindAsync(id);
            if (socialToTeam == null)
            {
                return NotFound();
            }
            ModelState.AddModelError("SocialId", "You must select any social");
            ModelState.AddModelError("TeamId", "You must select any team member");
            List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
            socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
            ViewBag.Social = socialid;
            List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;
            return View(socialToTeam);
        }

        // POST: Admin/SocialToTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamId,SocialId")] SocialToTeam model)
        {
            if (ModelState.IsValid)
            {
                if (model.SocialId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("SocialId", "You must select any social");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
                    socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
                    ViewBag.Social = socialid;
                    List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;

                    return View(model);
                }
                if (model.SocialId == 0)
                {
                    ModelState.AddModelError("SocialId", "You must select any social");
                    List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
                    socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
                    ViewBag.Social = socialid;
                    return View(model);
                }
                if (model.TeamId == 0)
                {
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;

                    return View(model);
                }
                else //if no photo
                {
                    if (model.SocialId == 0 && model.TeamId == 0)
                    {
                        ModelState.AddModelError("SocialId", "You must select any social");
                        ModelState.AddModelError("TeamId", "You must select any team member");
                        List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
                        socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
                        ViewBag.Social = socialid;
                        List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                        teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                        ViewBag.Team = teamid;

                        return View(model);
                    }
                    if (model.SocialId == 0)
                    {
                        ModelState.AddModelError("SocialId", "You must select any social");
                        List<Social> socialid = _context.Socials.Include(t => t.SocialToTeam).ThenInclude(r => r.Team).ToList();
                        socialid.Insert(0, new Social() { Id = 0, Icon = "Select" });
                        ViewBag.Social = socialid;
                        return View(model);
                    }
                    if (model.TeamId == 0)
                    {
                        ModelState.AddModelError("TeamId", "You must select any team member");
                        List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
                        teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                        ViewBag.Team = teamid;

                        return View(model);
                    }

                    _context.SocialToTeams.Update(model);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
        // GET: Admin/SocialToTeams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialToTeam = await _context.SocialToTeams
                .Include(s => s.Social)
                .Include(s => s.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialToTeam == null)
            {
                return NotFound();
            }

            return View(socialToTeam);
        }

        // POST: Admin/SocialToTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socialToTeam = await _context.SocialToTeams.FindAsync(id);
            _context.SocialToTeams.Remove(socialToTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialToTeamExists(int id)
        {
            return _context.SocialToTeams.Any(e => e.Id == id);
        }
    }
}
