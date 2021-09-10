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
    public class DurationTimesController : Controller
    {
        private readonly AppDbContext _context;

        public DurationTimesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/DurationTimes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DurationTimes.ToListAsync());
        }

        // GET: Admin/DurationTimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var durationTime = await _context.DurationTimes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (durationTime == null)
            {
                return NotFound();
            }

            return View(durationTime);
        }

        // GET: Admin/DurationTimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/DurationTimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Times")] DurationTime durationTime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(durationTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(durationTime);
        }

        // GET: Admin/DurationTimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var durationTime = await _context.DurationTimes.FindAsync(id);
            if (durationTime == null)
            {
                return NotFound();
            }
            return View(durationTime);
        }

        // POST: Admin/DurationTimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Times")] DurationTime durationTime)
        {
            if (id != durationTime.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(durationTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DurationTimeExists(durationTime.Id))
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
            return View(durationTime);
        }

        // GET: Admin/DurationTimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var durationTime = await _context.DurationTimes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (durationTime == null)
            {
                return NotFound();
            }

            return View(durationTime);
        }

        // POST: Admin/DurationTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var durationTime = await _context.DurationTimes.FindAsync(id);
            _context.DurationTimes.Remove(durationTime);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DurationTimeExists(int id)
        {
            return _context.DurationTimes.Any(e => e.Id == id);
        }
    }
}
