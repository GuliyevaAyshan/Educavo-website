using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Services.ClientNotification;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
           
            _context = context;
        }
        public IActionResult Index(int? id, string searchData, int? year, int? month)
        {
           
            IList<Blog> blogs = _context.Blog
                 .Where(b => (id == null || b.CategoryId == id) &&         
                             (year != null ? b.AddedDate.Year == year : true) &&
                             (month != null ? b.AddedDate.Month == month : true)&&
                              ((searchData == null || b.Title.Contains(searchData)) ||
                              (searchData == null || b.Categories.Name.Contains(searchData)) ||
                              (searchData == null || b.Content.Contains(searchData)) ||
                              (searchData == null || b.AddedDate.ToString().Contains(searchData))))
                             .ToList();

            VMBlog model = new VMBlog()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Categories = _context.Categories.Include(b => b.Blogs).ToList(),
                Blogs = blogs,
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.ToList(),
                RecentPost = _context.Blog.OrderBy(o => o.Id).Take(5).ToList(),
         
                Users = _context.Users.Include(b => b.Blogs).ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                VMDates = _context.Blog.GroupBy(d => new
                {
                    Monthes = d.AddedDate.Month,
                    Years = d.AddedDate.Year
                })
                                        .Select(a => new VMDate
                                        {
                                            Year = a.Key.Years,
                                            Month = a.Key.Monthes,
                                            Count = a.Count()
                                        })
                                        .ToList()

            };
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index", "error");
            }

            int catId = _context.Blog.Find(id).CategoryId;
            
            VMBlog model = new VMBlog()
            {
                Blog = _context.Blog.Include(u=>u.Users).Include(i=>i.Categories).FirstOrDefault(i => i.Id == id),
                Comment =_context.Comments.FirstOrDefault(),
                Comments = _context.Comments.Where(c => c.BlogId == id).ToList(),
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Categories = _context.Categories.Include(b => b.Blogs).ToList(),
                RelatedBlogs = _context.Blog.Where(b => (b.CategoryId == catId && b.Id != id)).ToList(),
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                RecentPost = _context.Blog.OrderByDescending(o => o.AddedDate).Take(5).ToList(),
              
                Users = _context.Users.Include(b => b.Blogs).ToList(),
                VMDates = _context.Blog.GroupBy(d => new
                {
                    Monthes = d.AddedDate.Month,
                    Years = d.AddedDate.Year
                })
                                        .Select(a => new VMDate
                                        {
                                            Year = a.Key.Years,
                                            Month = a.Key.Monthes,
                                            Count = a.Count()
                                        })
                                        .ToList()

            };
            int currentBlogIndex = _context.Blog.ToList().IndexOf(model.Blog);


            if ((currentBlogIndex + 1) > (_context.Blog.Count() - 1))
            {
                ViewBag.NextBlog = null;
            }
            else
            {
                ViewBag.NextBlog = _context.Blog.ToList()[currentBlogIndex + 1].Id;
                ViewBag.Next = _context.Blog.ToList()[currentBlogIndex + 1].Title;
                ViewBag.NextPic = _context.Blog.ToList()[currentBlogIndex + 1].Image;
            }

            //if ((currentBlogIndex - 1) < 0)
            //{
            //    ViewBag.PrevBlog = null;
            //}
            //else
            //{
            //    ViewBag.PrevBlog = _context.Blog.ToList()[currentBlogIndex - 1].Id;
            //    ViewBag.Prev = _context.Blog.ToList()[currentBlogIndex + 1].Title;
            //}
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateComment(string Message, int blogId)
        {
            string valid = HttpContext.Session.GetString("ValidCustomer");
            if (valid != null)
            {
                Customer customer = JsonConvert.DeserializeObject<Customer>(valid);
                Comment comment = new Comment()
                {
                    Message = Message,         
                    BlogId =blogId,
                    CustomerId = customer.Id,
                    AddedDate = DateTime.Now
                };

                _context.Comments.Add(comment);
                _context.SaveChanges();

                return RedirectToAction("details", "Blog", new { id = blogId });
            }


            return RedirectToAction("login", "home", new { isCommentBlogId = blogId });

        }
    }
}
