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
    public class OfferStatesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        public OfferStatesController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Admin/OfferStates
        public async Task<IActionResult> Index()
        {
            return View(await _context.OfferStates.ToListAsync());
        }

        // GET: Admin/OfferStates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerState = await _context.OfferStates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offerState == null)
            {
                return NotFound();
            }

            return View(offerState);
        }

        // GET: Admin/OfferStates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/OfferStates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OfferState model)
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

                            _context.OfferStates.Add(model);
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

        // GET: Admin/OfferStates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerState = await _context.OfferStates.FindAsync(id);
            if (offerState == null)
            {
                return NotFound();
            }
            return View(offerState);
        }

        // POST: Admin/OfferStates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OfferState model)
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

        // GET: Admin/OfferStates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerState = await _context.OfferStates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offerState == null)
            {
                return NotFound();
            }

            return View(offerState);
        }

        // POST: Admin/OfferStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offerState = await _context.OfferStates.FindAsync(id);
            _context.OfferStates.Remove(offerState);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfferStateExists(int id)
        {
            return _context.OfferStates.Any(e => e.Id == id);
        }
    }
}
