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
    public class CurriculaController : Controller
    {
        private readonly AppDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public CurriculaController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Admin/Curricula
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Curriculum.Include(c => c.Courses).Include(c => c.CurriculumTitles);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/Curricula/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculum = await _context.Curriculum
                .Include(c => c.Courses)
                .Include(c => c.CurriculumTitles)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculum == null)
            {
                return NotFound();
            }

            return View(curriculum);
        }

        // GET: Admin/Curricula/Create
        public IActionResult Create()
        {
            List<Courses> courid = _context.Courses.ToList();
            courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courid;
            List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
            curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
            ViewBag.CurriculumTitles = curid;
            return View();
        }

        // POST: Admin/Curricula/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Curriculum model)
        {
            if (ModelState.IsValid)
            {
                if (model.CoursesId == 0 && model.CurriculumTitlesId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    ModelState.AddModelError("CurriculumTitlesId", "You must select any curriculum titles");

                    List<Courses> courid = _context.Courses.ToList();
                    courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courid;
                    List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
                    curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
                    ViewBag.CurriculumTitles = curid;
                   
                    return View(model);
                }
                if (model.CoursesId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    List<Courses> courid = _context.Courses.ToList();
                    courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courid;
                    return View(model);
                }
                if (model.CurriculumTitlesId == 0)
                {
                    ModelState.AddModelError("CurriculumTitlesId", "You must select any curriculum titles");
                    List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
                    curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
                    ViewBag.CurriculumTitles = curid;
                    return View(model);
                }
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

                            _context.Curriculum.Add(model);
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


        // GET: Admin/Curricula/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculum = await _context.Curriculum.FindAsync(id);
            if (curriculum == null)
            {
                return NotFound();
            }
            List<Courses> courid = _context.Courses.ToList();
            courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
            ViewBag.Courses = courid;
            List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
            curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
            ViewBag.CurriculumTitles = curid;
            return View(curriculum);
        }

        // POST: Admin/Curricula/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Curriculum model)
        {
           
            if (ModelState.IsValid)
            {
                if (model.CoursesId == 0 && model.CurriculumTitlesId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    ModelState.AddModelError("CurriculumTitlesId", "You must select any curriculum titles");

                    List<Courses> courid = _context.Courses.ToList();
                    courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courid;
                    List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
                    curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
                    ViewBag.CurriculumTitles = curid;

                    return View(model);
                }
                if (model.CoursesId == 0)
                {
                    ModelState.AddModelError("CourseId", "You must select any course");
                    List<Courses> courid = _context.Courses.ToList();
                    courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                    ViewBag.Courses = courid;
                    return View(model);
                }
                if (model.CurriculumTitlesId == 0)
                {
                    ModelState.AddModelError("CurriculumTitlesId", "You must select any curriculum titles");
                    List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
                    curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
                    ViewBag.CurriculumTitles = curid;
                    return View(model);
                }
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
                    if (model.CoursesId == 0 && model.CurriculumTitlesId == 0)
                    {
                        ModelState.AddModelError("CourseId", "You must select any course");
                        ModelState.AddModelError("CurriculumTitlesId", "You must select any curriculum titles");

                        List<Courses> courid = _context.Courses.ToList();
                        courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                        ViewBag.Courses = courid;
                        List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
                        curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
                        ViewBag.CurriculumTitles = curid;

                        return View(model);
                    }
                    if (model.CoursesId == 0)
                    {
                        ModelState.AddModelError("CourseId", "You must select any course");
                        List<Courses> courid = _context.Courses.ToList();
                        courid.Insert(0, new Courses() { Id = 0, Title = "Select" });
                        ViewBag.Courses = courid;
                        return View(model);
                    }
                    if (model.CurriculumTitlesId == 0)
                    {
                        ModelState.AddModelError("CurriculumTitlesId", "You must select any curriculum titles");
                        List<CurriculumTitles> curid = _context.CurriculumTitles.ToList();
                        curid.Insert(0, new CurriculumTitles() { Id = 0, Title = "Select" });
                        ViewBag.CurriculumTitles = curid;
                        return View(model);
                    }

                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
        // GET: Admin/Curricula/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculum = await _context.Curriculum
                .Include(c => c.Courses)
                .Include(c => c.CurriculumTitles)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculum == null)
            {
                return NotFound();
            }

            return View(curriculum);
        }

        // POST: Admin/Curricula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curriculum = await _context.Curriculum.FindAsync(id);
            _context.Curriculum.Remove(curriculum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculumExists(int id)
        {
            return _context.Curriculum.Any(e => e.Id == id);
        }
    }
}
