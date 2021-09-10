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
    public class TeamToCoursesController : Controller
    {
        private readonly AppDbContext _context;

        public TeamToCoursesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/TeamToCourses
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.TeamToCourses.Include(t => t.Course).Include(t => t.Team);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/TeamToCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamToCourses = await _context.TeamToCourses
                .Include(t => t.Course)
                .Include(t => t.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamToCourses == null)
            {
                return NotFound();
            }

            return View(teamToCourses);
        }

        // GET: Admin/TeamToCourses/Create
        public IActionResult Create()
        {
            List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
            courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courseid;
            List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;
            return View();
        }

        // POST: Admin/TeamToCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TeamToCourses model)
        {
            if (ModelState.IsValid)
            {
                if (model.CourseId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
                    courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courseid;
                    List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;



                    return View(model);
                }
                if (model.CourseId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
                    courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courseid;
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
        // GET: Admin/TeamToCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamToCourses = await _context.TeamToCourses.FindAsync(id);
            if (teamToCourses == null)
            {
                return NotFound();
            }
            ModelState.AddModelError("CourseId", "You must select any course");
            ModelState.AddModelError("TeamId", "You must select any team member");
            List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
            courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courseid;
            List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
            teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
            ViewBag.Team = teamid;

            return View(teamToCourses);
        }

        // POST: Admin/TeamToCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TeamToCourses model)
        {
            if (ModelState.IsValid)
            {
                if (model.CourseId == 0 && model.TeamId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    ModelState.AddModelError("TeamId", "You must select any team member");
                    List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
                    courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courseid;
                    List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
                    teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                    ViewBag.Team = teamid;




                    return View(model);
                }
                if (model.CourseId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
                    courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courseid;
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
                    if (model.CourseId == 0 && model.TeamId == 0)
                    {

                        ModelState.AddModelError("CourseId", "You must select any course");
                        ModelState.AddModelError("TeamId", "You must select any team member");
                        List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
                        courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                        ViewBag.Courses = courseid;
                        List<Team> teamid = _context.Team.Include(t => t.TeamToCourses).ThenInclude(r => r.Course).ToList();
                        teamid.Insert(0, new Team() { Id = 0, FullName = "Select" });
                        ViewBag.Team = teamid;



                        return View(model);
                    }
                    if (model.CourseId == 0)
                    {
                        ModelState.AddModelError("CourseId", "You must select any course");
                        List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
                        courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                        ViewBag.Courses = courseid;
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

                    _context.TeamToCourses.Update(model);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
        // GET: Admin/TeamToCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamToCourses = await _context.TeamToCourses
                .Include(t => t.Course)
                .Include(t => t.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamToCourses == null)
            {
                return NotFound();
            }

            return View(teamToCourses);
        }

        // POST: Admin/TeamToCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamToCourses = await _context.TeamToCourses.FindAsync(id);
            _context.TeamToCourses.Remove(teamToCourses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamToCoursesExists(int id)
        {
            return _context.TeamToCourses.Any(e => e.Id == id);
        }
    }
}
