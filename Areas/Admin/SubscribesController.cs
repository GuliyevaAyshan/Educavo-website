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
    public class SubscribesController : Controller
    {
        private readonly AppDbContext _context;

        public SubscribesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Subscribes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subscribe.ToListAsync());
        }

      

        // GET: Admin/Subscribes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscribe = await _context.Subscribe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscribe == null)
            {
                return NotFound();
            }

            return View(subscribe);
        }

        // POST: Admin/Subscribes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscribe = await _context.Subscribe.FindAsync(id);
            _context.Subscribe.Remove(subscribe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscribeExists(int id)
        {
            return _context.Subscribe.Any(e => e.Id == id);
        }
    }
}
