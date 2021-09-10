using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AppDbContext _context;

        public GalleryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        { VMGallery model = new VMGallery()
        {
            RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
            Galleries = _context.Galleries.ToList(),
            Socials = _context.Socials.ToList(),
            Subscribe = _context.Subscribe.FirstOrDefault(),
            Contacts = _context.Contacts.ToList()
        };

           
            return View(model);
        }
    }
}
