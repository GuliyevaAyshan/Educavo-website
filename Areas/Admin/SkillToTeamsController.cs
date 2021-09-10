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
    public class SkillToTeamsController : Controller
    {
        private readonly AppDbContext _context;

        public SkillToTeamsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SkillToTeams
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.SkillToTeams.Include(s => s.Skill).Include(s => s.Team);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/SkillToTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillToTeam = await _context.SkillToTeams
                .Include(s => s.Skill)
                .Include(s => s.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skillToTeam == null)
            {
                return NotFound();
            }

            return View(skillToTeam);
        }

        // GET: Admin/SkillToTeams/Create
        public IActionResult Create()
        {
            List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
            skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
            ViewBag.Skill = skillid;
            List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;
            return View();
     
        }

        // POST: Admin/SkillToTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SkillToTeam model)
        {
            if (ModelState.IsValid)
            {
                if (model.SkillId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("SkillId", "You must select any skill");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
                    skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
                    ViewBag.Skill = skillid;
                    List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;

                    return View(model);
                }
                if (model.SkillId == 0)
                {
                    ModelState.AddModelError("SkillId", "You must select any skill");
                    List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
                    skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
                    ViewBag.Skill = skillid;
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

        // GET: Admin/SkillToTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillToTeam = await _context.SkillToTeams.FindAsync(id);
            if (skillToTeam == null)
            {
                return NotFound();
            }

            ModelState.AddModelError("SkillId", "You must select any skill");
            ModelState.AddModelError("TeamId", "You must select any team member");
            List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
            skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
            ViewBag.Skill = skillid;
            List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;
    
            return View(skillToTeam);
        }

        // POST: Admin/SkillToTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamId,SkillId,Persentage")] SkillToTeam model)
        {
            if (ModelState.IsValid)
            {
                if (model.SkillId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("SkillId", "You must select any skill");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
                    skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
                    ViewBag.Skill = skillid;
                    List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;

                    return View(model);
                }
                if (model.SkillId == 0)
                {
                    ModelState.AddModelError("SkillId", "You must select any skill");
                    List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
                    skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
                    ViewBag.Skill = skillid;
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
                    if (model.SkillId == 0 && model.TeamId == 0)
                    {
                        ModelState.AddModelError("SkillId", "You must select any skill");
                        ModelState.AddModelError("TeamId", "You must select any team member");
                        List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
                        skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
                        ViewBag.Skill = skillid;
                        List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                        teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                        ViewBag.Team = teamid;

                        return View(model);
                    }
                    if (model.SkillId == 0)
                    {
                        ModelState.AddModelError("SkillId", "You must select any skill");
                        List<Skill> skillid = _context.Skills.Include(t => t.SkillToTeam).ThenInclude(r => r.Team).ToList();
                        skillid.Insert(0, new Skill() { Id = 0, Name = "Select" });
                        ViewBag.Skill = skillid;
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

                    _context.SkillToTeams.Update(model);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
        // GET: Admin/SkillToTeams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillToTeam = await _context.SkillToTeams
                .Include(s => s.Skill)
                .Include(s => s.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skillToTeam == null)
            {
                return NotFound();
            }

            return View(skillToTeam);
        }

        // POST: Admin/SkillToTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skillToTeam = await _context.SkillToTeams.FindAsync(id);
            _context.SkillToTeams.Remove(skillToTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillToTeamExists(int id)
        {
            return _context.SkillToTeams.Any(e => e.Id == id);
        }
    }
}
