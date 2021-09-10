using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id, VMCourses CourseFilter, string searchData, int page = 1)
        {
            ViewBag.Filter = new Dictionary<string, string>
            {
                {"skillLevelId",CourseFilter.skillLevelId.ToString() },
                {"priceLevelId",CourseFilter.priceLevelId.ToString()  },
                {"durationTimeId",CourseFilter.durationTimeId.ToString()  },
                {"courseTypesId",CourseFilter.courseTypesId+"" },
                {"instructorId",CourseFilter.instructorId.ToString() },
                {"catId",CourseFilter.catId.ToString() },

            };

            decimal pageItemCount = 8;

            List<Courses> courseList = _context.Courses.Include(k => k.CourseTypes).Where(b => (CourseFilter.catId == null || b.CategoryId == CourseFilter.catId) &&
                                                                      (CourseFilter.priceLevelId == null || b.PriceLevelId == CourseFilter.priceLevelId) &&
                                                                    (CourseFilter.skillLevelId == null || b.SkillLevelId == CourseFilter.skillLevelId) &&
                                                                     //(CourseFilter.courseTypesId.Count == 0 || CourseFilter.courseTypesId.Any(a => a == b.CourseTypesId)) &&
                                                                     (CourseFilter.instructorId == null || b.TeamToCourses.FirstOrDefault().TeamId == CourseFilter.instructorId) &&
                                                                     (CourseFilter.durationTimeId == null || b.DurationTimeId == CourseFilter.durationTimeId) &&
                                                                     ((searchData == null || b.Title.Contains(searchData)) || (searchData == null || b.Categories.Name.Contains(searchData)))
                                                                   ).Include(r => r.Review).ToList();

            List<CourseTypes> courseTypes = _context.CourseTypes.ToList();
            courseTypes.Insert(0, new CourseTypes { Id = 0, Types = "Select*" });
            ViewBag.CourseType = courseTypes;

            decimal b = Math.Ceiling(courseList.Count / pageItemCount);
            ViewBag.PageCount = Convert.ToInt32(b);
            ViewBag.ActivePage = page;

            List<Courses> courses = courseList.OrderBy(p => p.Id)
                                                     .Skip((page - 1) * (int)pageItemCount).Take((int)pageItemCount)
                                                     .ToList();


            VMCourses model = new VMCourses()

            {
                Courses = courses,

                SkillLevel = _context.SkillLevels.Include(c => c.Courses).ToList(),
                PriceLevel = _context.PriceLevels.Include(k => k.Courses).ToList(),
                Categories = _context.Categories.Include(c => c.Courses).ToList(),
                CourseTypes = _context.CourseTypes.ToList(),
                Team = _context.Team.Include(d => d.TeamToCourses).ThenInclude(d => d.Course).ToList(),
                DurationTime = _context.DurationTimes.Include(d => d.Course).ToList(),
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Review = _context.Reviews.ToList(),
                Course = _context.Courses.Include(r => r.Review).Include(k => k.CourseTypes).FirstOrDefault(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.ToList(),
                CustomUser = _context.Customers.Include(b => b.Courses).ToList(),
                Filter = CourseFilter

            };

            return View(model);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index","error");
            }
            int catId = _context.Courses.Find(id).CategoryId;

            VMCourses model = new VMCourses()
            {
                Team = _context.Team.Include(t => t.TeamToCourses).ThenInclude(d => d.Course).Include(s => s.SocialToTeam).ThenInclude(e => e.Social).Include(r => r.Review).ToList(),
                TeamToCourses = _context.TeamToCourses.Include(k => k.Course).ToList(),
                Faqs = _context.Faqs.Include(t => t.FaqTitles).ToList(),
                FaqTitles = _context.FaqTitles.ToList(),
                CurriculumTitles = _context.CurriculumTitles.Include(k => k.Curriculum).ToList(),
                Curriculum = _context.Curriculum.Include(c => c.Courses).ToList(),
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Review = _context.Reviews.Include(t => t.Team).ThenInclude(t => t.TeamToCourses).Include(c => c.Customer).ToList(),
                ReviewToCourse = _context.Reviews.Include(c => c.Courses).ToList(),
                Categories = _context.Categories.Include(b => b.Courses).ToList(),
                RecentCourses = _context.Courses.OrderByDescending(o => o.AddedDate).Take(1).ToList(),
                RelatedCourses = _context.Courses.Where(b => (b.CategoryId == catId && b.Id != id)).OrderByDescending(a => a.AddedDate).ToList(),
                Socials = _context.Socials.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Contacts = _context.Contacts.ToList(),
                Instructor = _context.Team.Include(k => k.Review).FirstOrDefault(i => i.Id == id),
                Course = _context.Courses.Include(f => f.FaqToCourses).ThenInclude(ft => ft.Faq)
                .Include(r => r.Review)
                .Include(a => a.DurationTime)
                .Include(s => s.Curriculum)
                .Include(s => s.SkillLevel)
                .Include(b => b.CourseTypes)
                .Include(t => t.TeamToCourses).ThenInclude(tm => tm.Team).Include(r => r.Review).FirstOrDefault(i => i.Id == id)

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddReview(string Text, byte Rating, int courseId, int instructorId)
        {


            string valid = HttpContext.Session.GetString("ValidCustomer");
            if (valid != null)
            {
                Customer customer = JsonConvert.DeserializeObject<Customer>(valid);

                Review review = new Review()
                {
                    Text = Text,
                    Rating = Rating,
                    CoursesId = courseId,
                    TeamId = instructorId,
                    AddedDate = DateTime.Now,
                    CustomerId = customer.Id


                };

                _context.Reviews.Add(review);
                _context.SaveChanges();

                return RedirectToAction("details", "Course", new { id = courseId });
            }
            else
            {
                return RedirectToAction("login", "home", new { isCommentCourseId = courseId,isCommentInstructorId= instructorId });
            }
        }


    }
}

