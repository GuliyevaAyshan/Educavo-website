using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduCavoFinal.Data;
using EduCavoFinal.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using EduCavoFinal.Filters;

namespace EduCavoFinal.Areas.Admin
{
    [Area("Admin")]
    [AuthUser]
    public class AboutsController : Controller
    {
        private readonly AppDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public AboutsController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Admin/Abouts
        public async Task<IActionResult> Index()
        {
            return View(await _context.About.ToListAsync());
        }

        // GET: Admin/Abouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.About
                .FirstOrDefaultAsync(m => m.Id == id);
            if (about == null)
            {
                return NotFound();
            }

            return View(about);
        }

        // GET: Admin/Abouts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Abouts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public IActionResult Create(About model)
        {
            if (ModelState.IsValid)
            {
                if (model.VideoFile != null)
                {

                    if (model.VideoFile.ContentType == "video/mp4")
                    {
                        if (model.VideoFile.Length <= 100000000)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss") + "-" + model.VideoFile.FileName;
                            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Videos", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.VideoFile.CopyTo(stream);
                            }
                            model.Video = fileName;

                            _context.About.Add(model);
                            _context.SaveChanges();
                            
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("VideoFile", "Can upload max 10MB");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("VideoFile", "Only mp4 types");
                    }

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

        // GET: Admin/Abouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.About.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        // POST: Admin/Abouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,About model)
        {
            if (ModelState.IsValid)
            {
                if (model.VideoFile != null)
                {

                    if (model.VideoFile.ContentType == "video/mp4")
                    {
                        if (model.VideoFile.Length <= 100000000)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss") + "-" + model.VideoFile.FileName;
                            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Videos", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.VideoFile.CopyTo(stream);
                            }
                            model.Video = fileName;
                            _context.Entry(model).State = EntityState.Modified;
                            _context.SaveChanges();

                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("VideoFile", "Can upload max 10MB");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("VideoFile", "Only mp4 types");
                    }

                }
                else //if no photo
                {
                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Admin/Abouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.About
                .FirstOrDefaultAsync(m => m.Id == id);
            if (about == null)
            {
                return NotFound();
            }

            return View(about);
        }

        // POST: Admin/Abouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var about = await _context.About.FindAsync(id);
            _context.About.Remove(about);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutExists(int id)
        {
            return _context.About.Any(e => e.Id == id);
        }
    }
}
