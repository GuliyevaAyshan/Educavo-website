using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class ContactController : Controller
    {
      
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
         
            _context = context;
        }
        public IActionResult Index()
        {
            VMContact model = new VMContact()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Socials = _context.Socials.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Contacts = _context.Contacts.ToList(),
                Messages=_context.Messages.ToList()
            };
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string Message,string Subject,string Phone)
        {
   
            string valid = HttpContext.Session.GetString("ValidCustomer");
            if (valid != null)
            {
                Customer customer = JsonConvert.DeserializeObject<Customer>(valid);

                Message message = new Message()
                {
                    Email=customer.Email,
                     Name=customer.Name,
                    Phone = Phone,
                    AddedDate = DateTime.Now,
                    MessageText =Message,
                    Subject=Subject,
                };

                _context.Messages.Add(message);
                _context.SaveChanges();

             

                return RedirectToAction("index", "home");
            }
            else
            {
                return RedirectToAction("login", "home");
            }
        }
    }
}

