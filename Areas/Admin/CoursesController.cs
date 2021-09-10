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
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public CoursesController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Admin/Courses
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Courses.Include(c => c.Categories).Include(c => c.DurationTime).Include(c => c.PriceLevel).Include(c => c.SkillLevel).Include(c => c.CourseTypes);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .Include(c => c.Categories)
                .Include(c => c.DurationTime)
                .Include(c => c.PriceLevel)
                .Include(c => c.SkillLevel)
                .Include(c => c.CourseTypes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // GET: Admin/Courses/Create
        public IActionResult Create()
        {
            List<Categories> categories = _context.Categories.ToList();
            categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
            ViewBag.Categories = categories;
            List<DurationTime> durationTimes = _context.DurationTimes.ToList();
            durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
            ViewBag.DurationTimes = durationTimes;
            List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
            priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
            ViewBag.PriceLevel = priceLevels;
            List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
            skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
            ViewBag.SkillLevel = skillLevels;
            List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
            courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
            ViewBag.CourseTypes = courseTypes;

            return View();
        }

        // POST: Admin/Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public IActionResult Create(Courses model)
        {
            if (ModelState.IsValid)
            {
                if (model.CategoryId == 0 && model.SkillLevelId == 0 && model.PriceLevelId == 0 && model.DurationTimeId == 0 && model.CourseTypesId == 0)
                {
                    ModelState.AddModelError("CategoryId", "You must select any category");
                    ModelState.AddModelError("SkillLevelId", "You must select any skill level");
                    ModelState.AddModelError("PriceLevelId", "You must select any price level");
                    ModelState.AddModelError("DurationTimeId", "You must select any duration time.");
                    ModelState.AddModelError("CourseTypesId", "You must select any course types");

                    List<Categories> categories = _context.Categories.ToList();
                    categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                    ViewBag.Categories = categories;
                    List<DurationTime> durationTimes = _context.DurationTimes.ToList();
                    durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
                    ViewBag.DurationTimes = durationTimes;
                    List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
                    priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
                    ViewBag.PriceLevel = priceLevels;
                    List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
                    skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
                    ViewBag.SkillLevel = skillLevels;
                    List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
                    courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
                    ViewBag.CourseTypes = courseTypes;
                    return View(model);
                }
                if (model.CategoryId == 0)
                {
                    ModelState.AddModelError("CategoryId", "You must select any category");
                    List<Categories> categories = _context.Categories.ToList();
                    categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                    ViewBag.Categories = categories;
                    return View(model);
                }
                if (model.SkillLevelId == 0)
                {
                    ModelState.AddModelError("SkillLevelId", "You must select any skill level");
                    List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
                    skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
                    ViewBag.SkillLevel = skillLevels;
                    return View(model);
                }
                if (model.PriceLevelId == 0)
                {

                    ModelState.AddModelError("PriceLevelId", "You must select any price level");
                    List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
                    priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
                    ViewBag.PriceLevel = priceLevels;
                    return View(model);
                }
                if (model.DurationTimeId == 0)
                {

                    ModelState.AddModelError("DurationTimeId", "You must select any duration time");
                    List<DurationTime> durationTimes = _context.DurationTimes.ToList();
                    durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
                    ViewBag.DurationTimes = durationTimes;
                    return View(model);
                }
                if (model.CourseTypesId == 0)
                {

                    ModelState.AddModelError("CourseTypesId", "You must select any course types");
                    List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
                    courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
                    ViewBag.CourseTypes = courseTypes;
                    return View(model);
                }

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

                            _context.Courses.Add(model);
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

        // GET: Admin/Courses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courses = _context.Courses
                .Include(c => c.Categories)
                .Include(c => c.DurationTime)
                .Include(c => c.PriceLevel)
                .Include(c => c.SkillLevel)
                .Include(c => c.CourseTypes)
                .FirstOrDefault(m => m.Id == id);
            if (courses == null)
            {
                return NotFound();
            }
            List<Categories> categories = _context.Categories.ToList();
            categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
            ViewBag.Categories = categories;
            List<DurationTime> durationTimes = _context.DurationTimes.ToList();
            durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
            ViewBag.DurationTimes = durationTimes;
            List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
            priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
            ViewBag.PriceLevel = priceLevels;
            List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
            skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
            ViewBag.SkillLevel = skillLevels;
            List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
            courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
            ViewBag.CourseTypes = courseTypes;
           
            return View(courses);
        }

        // POST: Admin/Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public IActionResult Edit(Courses model)
        {          
            if (ModelState.IsValid)
            {
               
                    if (model.CategoryId == 0 && model.SkillLevelId == 0 && model.PriceLevelId == 0 && model.DurationTimeId == 0 && model.CourseTypesId == 0)
                    {
                        ModelState.AddModelError("CategoryId", "You must select any category");
                        ModelState.AddModelError("SkillLevelId", "You must select any skill level");
                        ModelState.AddModelError("PriceLevelId", "You must select any price level");
                        ModelState.AddModelError("DurationTimeId", "You must select any duration time.");
                        ModelState.AddModelError("CourseTypesId", "You must select any course types");

                        List<Categories> categories = _context.Categories.ToList();
                        categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                        ViewBag.Categories = categories;
                        List<DurationTime> durationTimes = _context.DurationTimes.ToList();
                        durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
                        ViewBag.DurationTimes = durationTimes;
                        List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
                        priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
                        ViewBag.PriceLevel = priceLevels;
                        List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
                        skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
                        ViewBag.SkillLevel = skillLevels;
                        List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
                        courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
                        ViewBag.CourseTypes = courseTypes;
                        return View(model);
                    }
                if (model.CategoryId == 0)
                {
                    ModelState.AddModelError("CategoryId", "You must select any category");
                    List<Categories> categories = _context.Categories.ToList();
                    categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                    ViewBag.Categories = categories;
                    return View(model);
                }
                if (model.SkillLevelId == 0)
                {
                    ModelState.AddModelError("SkillLevelId", "You must select any skill level");
                    List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
                    skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
                    ViewBag.SkillLevel = skillLevels;
                    return View(model);
                }
                if (model.PriceLevelId == 0)
                {

                    ModelState.AddModelError("PriceLevelId", "You must select any price level");
                    List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
                    priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
                    ViewBag.PriceLevel = priceLevels;
                    return View(model);
                }
                if (model.DurationTimeId == 0)
                {

                    ModelState.AddModelError("DurationTimeId", "You must select any duration time");
                    List<DurationTime> durationTimes = _context.DurationTimes.ToList();
                    durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
                    ViewBag.DurationTimes = durationTimes;
                    return View(model);
                }
                if (model.CourseTypesId == 0)
                {

                    ModelState.AddModelError("CourseTypesId", "You must select any course types");
                    List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
                    courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
                    ViewBag.CourseTypes = courseTypes;
                    return View(model);
                }
                if (model.ImageFile != null)
                {

                    if (model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpg" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            string oldFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "Uploads/Images", model.Image);
                            if (System.IO.File.Exists(oldFilePath))
                            {
                                System.IO.File.Delete(oldFilePath);
                            }
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
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
                            ModelState.AddModelError("ImageFile", "Siz maksimum 2 Mb hecmde fayllari upload ede bilersiniz!");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Siz yalniz .jpeg, .png, .gif tipli fayllari upload ede bilersiniz!");
                    }
                }
                else
                {
                    if (model.CategoryId == 0 && model.SkillLevelId == 0 && model.PriceLevelId == 0 && model.DurationTimeId == 0 && model.CourseTypesId == 0)
                    {
                        ModelState.AddModelError("CategoryId", "You must select any category");
                        ModelState.AddModelError("SkillLevelId", "You must select any skill level");
                        ModelState.AddModelError("PriceLevelId", "You must select any price level");
                        ModelState.AddModelError("DurationTimeId", "You must select any duration time.");
                        ModelState.AddModelError("CourseTypesId", "You must select any course types");

                        List<Categories> categories = _context.Categories.ToList();
                        categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                        ViewBag.Categories = categories;
                        List<DurationTime> durationTimes = _context.DurationTimes.ToList();
                        durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
                        ViewBag.DurationTimes = durationTimes;
                        List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
                        priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
                        ViewBag.PriceLevel = priceLevels;
                        List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
                        skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
                        ViewBag.SkillLevel = skillLevels;
                        List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
                        courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
                        ViewBag.CourseTypes = courseTypes;
                        return View(model);
                    }
                    if (model.CategoryId == 0)
                    {
                        ModelState.AddModelError("CategoryId", "You must select any category");
                        List<Categories> categories = _context.Categories.ToList();
                        categories.Insert(0, new Categories() { Id = 0, Name = "Select" });
                        ViewBag.Categories = categories;
                        return View(model);
                    }
                    if (model.SkillLevelId == 0)
                    {
                        ModelState.AddModelError("SkillLevelId", "You must select any skill level");
                        List<SkillLevel> skillLevels = _context.SkillLevels.ToList();
                        skillLevels.Insert(0, new SkillLevel() { Id = 0, Name = "Select" });
                        ViewBag.SkillLevel = skillLevels;
                        return View(model);
                    }
                    if (model.PriceLevelId == 0)
                    {

                        ModelState.AddModelError("PriceLevelId", "You must select any price level");
                        List<PriceLevel> priceLevels = _context.PriceLevels.ToList();
                        priceLevels.Insert(0, new PriceLevel() { Id = 0, Levels = "Select" });
                        ViewBag.PriceLevel = priceLevels;
                        return View(model);
                    }
                    if (model.DurationTimeId == 0)
                    {

                        ModelState.AddModelError("DurationTimeId", "You must select any duration time");
                        List<DurationTime> durationTimes = _context.DurationTimes.ToList();
                        durationTimes.Insert(0, new DurationTime() { Id = 0, Times = "Select" });
                        ViewBag.DurationTimes = durationTimes;
                        return View(model);
                    }
                    if (model.CourseTypesId == 0)
                    {

                        ModelState.AddModelError("CourseTypesId", "You must select any course types");
                        List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
                        courseTypes.Insert(0, new CourseTypes() { Id = 0, Types = "Select" });
                        ViewBag.CourseTypes = courseTypes;
                        return View(model);
                    }

                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
      
  
    // GET: Admin/Courses/Delete/5
    public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .Include(c => c.Categories)
                .Include(c => c.DurationTime)
                .Include(c => c.PriceLevel)
                .Include(c => c.SkillLevel)
                .Include(c => c.CourseTypes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // POST: Admin/Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courses = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursesExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
