﻿using System;
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
    public class SkillLevelsController : Controller
    {
        private readonly AppDbContext _context;

        public SkillLevelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SkillLevels
        public async Task<IActionResult> Index()
        {
            return View(await _context.SkillLevels.ToListAsync());
        }

        // GET: Admin/SkillLevels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillLevel = await _context.SkillLevels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skillLevel == null)
            {
                return NotFound();
            }

            return View(skillLevel);
        }

        // GET: Admin/SkillLevels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SkillLevels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] SkillLevel skillLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skillLevel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skillLevel);
        }

        // GET: Admin/SkillLevels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillLevel = await _context.SkillLevels.FindAsync(id);
            if (skillLevel == null)
            {
                return NotFound();
            }
            return View(skillLevel);
        }

        // POST: Admin/SkillLevels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] SkillLevel skillLevel)
        {
            if (id != skillLevel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skillLevel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillLevelExists(skillLevel.Id))
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
            return View(skillLevel);
        }

        // GET: Admin/SkillLevels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillLevel = await _context.SkillLevels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skillLevel == null)
            {
                return NotFound();
            }

            return View(skillLevel);
        }

        // POST: Admin/SkillLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skillLevel = await _context.SkillLevels.FindAsync(id);
            _context.SkillLevels.Remove(skillLevel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillLevelExists(int id)
        {
            return _context.SkillLevels.Any(e => e.Id == id);
        }
    }
}
