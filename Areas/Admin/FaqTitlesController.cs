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
    public class FaqTitlesController : Controller
    {
        private readonly AppDbContext _context;

        public FaqTitlesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/FaqTitles
        public async Task<IActionResult> Index()
        {
            return View(await _context.FaqTitles.ToListAsync());
        }

        // GET: Admin/FaqTitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqTitles = await _context.FaqTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faqTitles == null)
            {
                return NotFound();
            }

            return View(faqTitles);
        }

        // GET: Admin/FaqTitles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/FaqTitles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] FaqTitles faqTitles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faqTitles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faqTitles);
        }

        // GET: Admin/FaqTitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqTitles = await _context.FaqTitles.FindAsync(id);
            if (faqTitles == null)
            {
                return NotFound();
            }
            return View(faqTitles);
        }

        // POST: Admin/FaqTitles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] FaqTitles faqTitles)
        {
            if (id != faqTitles.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faqTitles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaqTitlesExists(faqTitles.Id))
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
            return View(faqTitles);
        }

        // GET: Admin/FaqTitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqTitles = await _context.FaqTitles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faqTitles == null)
            {
                return NotFound();
            }

            return View(faqTitles);
        }

        // POST: Admin/FaqTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faqTitles = await _context.FaqTitles.FindAsync(id);
            _context.FaqTitles.Remove(faqTitles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaqTitlesExists(int id)
        {
            return _context.FaqTitles.Any(e => e.Id == id);
        }
    }
}
