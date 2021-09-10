using EduCavoFinal.Data;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class ErrorController : Controller
    {
        private readonly AppDbContext _context;

        public ErrorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string searchData)
        {
            VMErrorPage model = new VMErrorPage()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Error =_context.Errors.Include(e=>e.Categories).Where(b=>(searchData == null || b.Categories.Name.Contains(searchData))).FirstOrDefault(),
                Socials = _context.Socials.ToList(),            
                Contacts = _context.Contacts.ToList()
            };
            return View(model);
        }
    }
}
