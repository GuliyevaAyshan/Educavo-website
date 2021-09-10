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
    public class ContactToTeamsController : Controller
    {
        private readonly AppDbContext _context;

        public ContactToTeamsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ContactToTeams
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.ContactToTeam.Include(c => c.Contact).Include(c => c.Team);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/ContactToTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactToTeam = await _context.ContactToTeam
                .Include(c => c.Contact)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactToTeam == null)
            {
                return NotFound();
            }

            return View(contactToTeam);
        }

        // GET: Admin/ContactToTeams/Create
        public IActionResult Create()
        {
            List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
            contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email="Select" });
            ViewBag.Contact = contactid;
            List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;
            return View();
        }

        // POST: Admin/ContactToTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ContactToTeam model)
        {
            if (ModelState.IsValid)
            {
                if (model.ContactId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("ContactId", "You must select any contact");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
                    contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email = "Select" });
                    ViewBag.Contact = contactid;
                    List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;

                    return View(model);
                }
                if (model.ContactId == 0)
                {
                    ModelState.AddModelError("ContactId", "You must select any contact");
                    List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
                    contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email = "Select" });
                    ViewBag.Contact = contactid;
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

        // GET: Admin/ContactToTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactToTeam = await _context.ContactToTeam.FindAsync(id);
            if (contactToTeam == null)
            {
                return NotFound();
            }
            ModelState.AddModelError("ContactId", "You must select any contact");
            ModelState.AddModelError("TeamId", "You must select any team member");
            List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
            contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email = "Select" });
            ViewBag.Contact = contactid;
            List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;
            return View(contactToTeam);
        }

        // POST: Admin/ContactToTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ContactToTeam model)
        {
            if (ModelState.IsValid)
            {
                if (model.ContactId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("ContactId", "You must select any contact");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
                    contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email = "Select" });
                    ViewBag.Contact = contactid;
                    List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;
                    return View(model);
                }
                if (model.ContactId == 0)
                {
                    ModelState.AddModelError("ContactId", "You must select any contact");
                    List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
                    contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email = "Select" });
                    ViewBag.Contact = contactid;
             
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
                    if (model.ContactId == 0 && model.TeamId == 0)
                    {
                        ModelState.AddModelError("ContactId", "You must select any contact");
                        ModelState.AddModelError("TeamId", "You must select any team member");
                        List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
                        contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email = "Select" });
                        ViewBag.Contact = contactid;
                        List<Team> teamid = _context.Team.Include(t => t.SkillToTeam).ThenInclude(r => r.Skill).ToList();
                        teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                        ViewBag.Team = teamid;
                        return View(model);
                    }
                    if (model.ContactId == 0)
                    {
                        ModelState.AddModelError("ContactId", "You must select any contact");
                        List<Contact> contactid = _context.Contacts.Include(t => t.ContactToTeam).ThenInclude(r => r.Team).ToList();
                        contactid.Insert(0, new Contact() { Id = 0, Phone = "Select", Email = "Select" });
                        ViewBag.Contact = contactid;

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

                    _context.ContactToTeam.Update(model);
                     _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Admin/ContactToTeams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactToTeam = await _context.ContactToTeam
                .Include(c => c.Contact)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactToTeam == null)
            {
                return NotFound();
            }

            return View(contactToTeam);
        }

        // POST: Admin/ContactToTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactToTeam = await _context.ContactToTeam.FindAsync(id);
            _context.ContactToTeam.Remove(contactToTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactToTeamExists(int id)
        {
            return _context.ContactToTeam.Any(e => e.Id == id);
        }
    }
}
