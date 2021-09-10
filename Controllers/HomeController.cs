using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Crypto = BCrypt.Net.BCrypt;
namespace EduCavoFinal.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
          
            _context = context;
        }
       
        public IActionResult Index()
        {

            VMHome model = new VMHome()
            {    Reviews=_context.Reviews.ToList(),
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                PopularCourses = _context.Courses.Include(c => c.Review).OrderByDescending(o => o.Lectures).Take(6).ToList(),
                PopularCategories = _context.Categories.Include(k=>k.Courses).Where(b => b.IsOnline == true).OrderByDescending(s=>s.OnlineCategoriesCount).Take(6).ToList(),
                ViewAllCategories = _context.Categories.Include(k => k.Courses).ToList(),
                LatestBlog = _context.Blog.Include(u => u.Users).Include(c=>c.Categories).OrderByDescending(o => o.Id).Skip(1).Take(6).ToList(),
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Sliders = _context.Sliders.ToList(),
                MostAskedFaqs = _context.Faqs.Include(d=>d.FaqToCourses).ThenInclude(dt=>dt.Course).Include(t=>t.FaqTitles).OrderByDescending(y=>y.Id).Take(4).ToList(),
                OfferStates = _context.OfferStates.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault()
            };

           
            return View(model);
        }
        public IActionResult Login()
        {
            VMCustomer model = new VMCustomer()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
               
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult Login(VMCustomer model)
        {

            model.RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList();
            model.Socials = _context.Socials.ToList();
            model.Contacts = _context.Contacts.ToList();
            model.Subscribe = _context.Subscribe.FirstOrDefault();

           
            if (ModelState.IsValid)
            {
                Customer customer = _context.Customers.FirstOrDefault(c => c.Email == model.Email);
                if (customer != null)
                {
                    if (Crypto.Verify(model.Password, customer.Password))
                    {
                        string customerObj = JsonConvert.SerializeObject(customer);
                        HttpContext.Session.SetString("ValidCustomer", customerObj);

                        return RedirectToAction("index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password duzgun deyil!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email movcud deyil!");
                }

            }
            return View(model);
        }
        public IActionResult Register()
        {
            VMCustomer model = new VMCustomer()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Socials = _context.Socials.ToList(),
                Contacts = _context.Contacts.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(VMCustomer model)
        {
            if (ModelState.IsValid)
            {
                if (model.ConfirmPassword == null)
                {
                    ModelState.AddModelError("ConfirmPassword", "Required");
                    return View(model);
                }

                if (model.Password == model.ConfirmPassword)
                {
                    Customer customer = new Customer();
                    customer.Name = model.Name;
                    customer.Email = model.Email;
                    customer.Surname = model.Surname;
                    customer.Username = model.Username;
                    customer.AddedDate = DateTime.Now;
                    customer.Password = Crypto.HashPassword(model.Password);
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                }
                else
                {
                    ModelState.AddModelError("ConfirmPassword", "Password not match!");
                    return View(model);
                }
            }
            return RedirectToAction("index", "home");
        }


       
        [HttpPost]
        public IActionResult Subscribe(Subscribe model)
        {
            if (ModelState.IsValid)
            {
                model.AddedDate = DateTime.Now;
                _context.Subscribe.Add(model);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}



