using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class FaqController : Controller
    {
        private readonly AppDbContext _context;

        public FaqController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        { 
        

            VMFaq model = new VMFaq()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Faqs = _context.Faqs.Include(t => t.FaqTitles).ToList(),
                FaqTitles=_context.FaqTitles.ToList(),
                Socials = _context.Socials.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Contacts = _context.Contacts.ToList()

            };
            return View(model);
        }
    }
}
