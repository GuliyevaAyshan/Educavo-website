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
    public class PriceLevelsController : Controller
    {
        private readonly AppDbContext _context;

        public PriceLevelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PriceLevels
        public async Task<IActionResult> Index()
        {
            return View(await _context.PriceLevels.ToListAsync());
        }

        // GET: Admin/PriceLevels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var priceLevel = await _context.PriceLevels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (priceLevel == null)
            {
                return NotFound();
            }

            return View(priceLevel);
        }

        // GET: Admin/PriceLevels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PriceLevels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Levels")] PriceLevel priceLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(priceLevel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(priceLevel);
        }

        // GET: Admin/PriceLevels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var priceLevel = await _context.PriceLevels.FindAsync(id);
            if (priceLevel == null)
            {
                return NotFound();
            }
            return View(priceLevel);
        }

        // POST: Admin/PriceLevels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Levels")] PriceLevel priceLevel)
        {
            if (id != priceLevel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(priceLevel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PriceLevelExists(priceLevel.Id))
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
            return View(priceLevel);
        }

        // GET: Admin/PriceLevels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var priceLevel = await _context.PriceLevels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (priceLevel == null)
            {
                return NotFound();
            }

            return View(priceLevel);
        }

        // POST: Admin/PriceLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var priceLevel = await _context.PriceLevels.FindAsync(id);
            _context.PriceLevels.Remove(priceLevel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PriceLevelExists(int id)
        {
            return _context.PriceLevels.Any(e => e.Id == id);
        }
    }
}
