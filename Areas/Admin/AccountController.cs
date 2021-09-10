using System;
using System.Linq;
using EduCavoFinal.Data;
using EduCavoFinal.Models;
using EduCavoFinal.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Crypto = BCrypt.Net.BCrypt;
using EduCavoFinal.Filters;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace EduCavoFinal.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AccountController(AppDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(VMUser model)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(c => c.Email == model.Email);
                if (user != null)
                {
                    if (Crypto.Verify(model.Password, user.Password))
                    {
                        string userObj = JsonConvert.SerializeObject(user);
                        HttpContext.Session.SetString("ValidUser", userObj);
                        return RedirectToAction("index", "home");
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
        [AuthUser]
        public IActionResult Register()
        {
            return View();
        }
        [AuthUser]
        [HttpPost]
        public IActionResult Register(User model)
        {
      
            if (ModelState.IsValid)
            {
              
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
                            if (model.ConfirmPassword == null)
                            {
                                ModelState.AddModelError("ConfirmPassword", "Required");
                                return View(model);
                            }

                            if (model.Password == model.ConfirmPassword)
                            {
                                User user = new User();                          
                                user.Name = model.Name;
                                user.Surname = model.Surname;
                                user.Username = model.Username;
                                user.Image = model.Image;
                                user.Email = model.Email;
                                user.IsTeamMember = model.IsTeamMember;
                                user.Gender = model.Gender;
                                user.Desc = model.Desc;
                                user.AddedDate = DateTime.Now;
                                user.Password = Crypto.HashPassword(model.Password);
                                _context.Users.Add(user);
                                _context.SaveChanges();

                            }
                            else
                            {
                                ModelState.AddModelError("ConfirmPassword", "Password not match!");
                                return View(model);
                            }

                            return RedirectToAction("Index", "users");
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
                    return RedirectToAction("Index", "users");
                }
            }
            return View(model);
        }
    }
}
