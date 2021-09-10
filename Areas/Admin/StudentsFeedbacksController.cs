using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduCavoFinal.Data;
using EduCavoFinal.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using EduCavoFinal.Filters;

namespace EduCavoFinal.Areas.Admin
{
    [Area("Admin")]
    [AuthUser]
    public class StudentsFeedbacksController : Controller
    {
        private readonly AppDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;
        public StudentsFeedbacksController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Admin/StudentsFeedbacks
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentsFeedbacks.ToListAsync());
        }

        // GET: Admin/StudentsFeedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsFeedback = await _context.StudentsFeedbacks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentsFeedback == null)
            {
                return NotFound();
            }

            return View(studentsFeedback);
        }

        // GET: Admin/StudentsFeedbacks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/StudentsFeedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentsFeedback model)
        {
            if (ModelState.IsValid)
            {

                if (model.ImageFile != null)
                {

                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpg" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }
                            model.Image = fileName;

                            _context.StudentsFeedbacks.Add(model);
                            _context.SaveChanges();

                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("ImageFile", "Can upload max 2MB");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Only .png, .jpg, .gif please!");
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

        // GET: Admin/StudentsFeedbacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsFeedback = await _context.StudentsFeedbacks.FindAsync(id);
            if (studentsFeedback == null)
            {
                return NotFound();
            }
            return View(studentsFeedback);
        }

        // POST: Admin/StudentsFeedbacks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentsFeedback model)
        {
            if (ModelState.IsValid)
            {

                if (model.ImageFile != null)
                {

                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpg" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }
                            model.Image = fileName;
                            _context.Entry(model).State = EntityState.Modified;
                            _context.SaveChanges();

                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("ImageFile", "Can upload max 2MB");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Only .png, .jpg, .gif please!");
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

        // GET: Admin/StudentsFeedbacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsFeedback = await _context.StudentsFeedbacks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentsFeedback == null)
            {
                return NotFound();
            }

            return View(studentsFeedback);
        }

        // POST: Admin/StudentsFeedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentsFeedback = await _context.StudentsFeedbacks.FindAsync(id);
            _context.StudentsFeedbacks.Remove(studentsFeedback);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentsFeedbackExists(int id)
        {
            return _context.StudentsFeedbacks.Any(e => e.Id == id);
        }
    }
}
