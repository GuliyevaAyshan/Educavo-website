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
    public class CourseTypesController : Controller
    {
        private readonly AppDbContext _context;

        public CourseTypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CourseTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseTypes.ToListAsync());
        }

        // GET: Admin/CourseTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTypes = await _context.CourseTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseTypes == null)
            {
                return NotFound();
            }

            return View(courseTypes);
        }

        // GET: Admin/CourseTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/CourseTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Types")] CourseTypes courseTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseTypes);
        }

        // GET: Admin/CourseTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTypes = await _context.CourseTypes.FindAsync(id);
            if (courseTypes == null)
            {
                return NotFound();
            }
            return View(courseTypes);
        }

        // POST: Admin/CourseTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Types")] CourseTypes courseTypes)
        {
            if (id != courseTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseTypesExists(courseTypes.Id))
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
            return View(courseTypes);
        }

        // GET: Admin/CourseTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseTypes = await _context.CourseTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseTypes == null)
            {
                return NotFound();
            }

            return View(courseTypes);
        }

        // POST: Admin/CourseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseTypes = await _context.CourseTypes.FindAsync(id);
            _context.CourseTypes.Remove(courseTypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseTypesExists(int id)
        {
            return _context.CourseTypes.Any(e => e.Id == id);
        }
    }
}
