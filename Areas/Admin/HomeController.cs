using EduCavoFinal.Data;
using EduCavoFinal.Filters;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Areas.Admin
{
    [Area("admin")]
    [AuthUser]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
      
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [AuthUser]
        public IActionResult Index()
        {
            VMAbouts model = new VMAbouts()
            {
                About=_context.About.FirstOrDefault(),
            };
            return View(model);
        }
    }
}

