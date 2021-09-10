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
    public class CurriculumTitlesController : Controller
    {
        private readonly AppDbContext _context;

        public CurriculumTitlesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CurriculumTitles
        public async Task<IActionResult> Index()
        {
            return View(await _context.CurriculumTitles.ToListAsync());
        }

        // GET: Admin/CurriculumTitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculumTitles = await _context.CurriculumTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculumTitles == null)
            {
                return NotFound();
            }

            return View(curriculumTitles);
        }

        // GET: Admin/CurriculumTitles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/CurriculumTitles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] CurriculumTitles curriculumTitles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curriculumTitles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(curriculumTitles);
        }

        // GET: Admin/CurriculumTitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculumTitles = await _context.CurriculumTitles.FindAsync(id);
            if (curriculumTitles == null)
            {
                return NotFound();
            }
            return View(curriculumTitles);
        }

        // POST: Admin/CurriculumTitles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] CurriculumTitles curriculumTitles)
        {
            if (id != curriculumTitles.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curriculumTitles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurriculumTitlesExists(curriculumTitles.Id))
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
            return View(curriculumTitles);
        }

        // GET: Admin/CurriculumTitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculumTitles = await _context.CurriculumTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculumTitles == null)
            {
                return NotFound();
            }

            return View(curriculumTitles);
        }

        // POST: Admin/CurriculumTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curriculumTitles = await _context.CurriculumTitles.FindAsync(id);
            _context.CurriculumTitles.Remove(curriculumTitles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculumTitlesExists(int id)
        {
            return _context.CurriculumTitles.Any(e => e.Id == id);
        }
    }
}
