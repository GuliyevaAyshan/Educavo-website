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
    public class FaqToCoursesController : Controller
    {
        private readonly AppDbContext _context;

        public FaqToCoursesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/FaqToCourses
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.FaqToCourses.Include(f => f.Course).Include(f => f.Faq);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/FaqToCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqToCourse = await _context.FaqToCourses
                .Include(f => f.Course)
                .Include(f => f.Faq)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faqToCourse == null)
            {
                return NotFound();
            }

            return View(faqToCourse);
        }

        // GET: Admin/FaqToCourses/Create
        public IActionResult Create()
        {
            List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
            courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courseid;
            List<Faq> faqid = _context.Faqs.Include(t => t.FaqToCourses).ThenInclude(r => r.Course).ToList();
            faqid.Insert(0, new Faq() { Id = 0, Questions = "Select" });
            ViewBag.Faq = faqid;
            return View();
        }

        // POST: Admin/FaqToCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseId,FaqId")] FaqToCourse faqToCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faqToCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
            courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courseid;
            List<Faq> faqid = _context.Faqs.Include(t => t.FaqToCourses).ThenInclude(r => r.Course).ToList();
            faqid.Insert(0, new Faq() { Id = 0, Questions = "Select" });
            ViewBag.Faq = faqid;
            return View(faqToCourse);
        }

        // GET: Admin/FaqToCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqToCourse = await _context.FaqToCourses.FindAsync(id);
            if (faqToCourse == null)
            {
                return NotFound();
            }
            List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
            courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courseid;
            List<Faq> faqid = _context.Faqs.Include(t => t.FaqToCourses).ThenInclude(r => r.Course).ToList();
            faqid.Insert(0, new Faq() { Id = 0, Questions = "Select" });
            ViewBag.Faq = faqid;
            return View(faqToCourse);
        }

        // POST: Admin/FaqToCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourseId,FaqId")] FaqToCourse faqToCourse)
        {
            if (id != faqToCourse.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faqToCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaqToCourseExists(faqToCourse.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            List<Courses> courseid = _context.Courses.Include(t => t.TeamToCourses).ThenInclude(r => r.Team).ToList();
            courseid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courseid;
            List<Faq> faqid = _context.Faqs.Include(t => t.FaqToCourses).ThenInclude(r => r.Course).ToList();
            faqid.Insert(0, new Faq() { Id = 0, Questions = "Select" });
            ViewBag.Faq = faqid;
            return View(faqToCourse);
        }

        // GET: Admin/FaqToCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqToCourse = await _context.FaqToCourses
                .Include(f => f.Course)
                .Include(f => f.Faq)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faqToCourse == null)
            {
                return NotFound();
            }

            return View(faqToCourse);
        }

        // POST: Admin/FaqToCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faqToCourse = await _context.FaqToCourses.FindAsync(id);
            _context.FaqToCourses.Remove(faqToCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaqToCourseExists(int id)
        {
            return _context.FaqToCourses.Any(e => e.Id == id);
        }
    }
}
