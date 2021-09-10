using EduCavoFinal.Data;
using EduCavoFinal.Filters;
using EduCavoFinal.Models;
using EduCavoFinal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Crypto = BCrypt.Net.BCrypt;
namespace EduCavoFinal.Controllers
{
    public class AccountController : Controller
    {
    
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
          
            _context = context;
        }
      
      
       
        [Auth]
        public IActionResult Index()
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
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("ValidCustomer");
            return RedirectToAction("index", "home");
        }

        public IActionResult ForgetPassword()
        {
            VMBase model = new VMBase()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Contacts = _context.Contacts.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Socials = _context.Socials.ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ForgetPassword(string email)
        {
            if (email != null)
            {
                Customer customer = _context.Customers.FirstOrDefault(c => c.Email == email);

                if (customer == null)
                {
                    HttpContext.Session.SetString("wrongMail", "true");
                    return View();
                }

                string token = "jsdfnvlsdbvklbfv";
                customer.Token = token;
                _context.Update(customer);
                _context.SaveChanges();


                //Sending mail
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("educavop509@gmail.com", "Educavo support");
                mail.To.Add(email);
                mail.Body = "<h1>Hello</h1>" +
                    "<p>For resetting password please visit the link below</p>" +
                    "<a href='https://localhost:44375/account/resetpassword?email=" + email + "&token=" + token + "'>Reset password</a>";
                mail.IsBodyHtml = true;
                mail.Subject = "Reset password";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
               
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("educavop509@gmail.com", "EducavoEduland2021");
                smtpClient.EnableSsl = true;
              
              
                smtpClient.Send(mail);
                //End of sending mail


                HttpContext.Session.SetString("mailSent", "true");
                return RedirectToAction("login", "home");
            }
            else
            {
                HttpContext.Session.SetString("wrongMail", "true");
               
            }
            return View();
        }

        public IActionResult ResetPassword(string email, string token)
        {
            VMResetPassword model = new VMResetPassword()
            {
                RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                Contacts = _context.Contacts.ToList(),
                Subscribe = _context.Subscribe.FirstOrDefault(),
                Socials = _context.Socials.ToList()
            };

            Customer customer = _context.Customers.FirstOrDefault(c => c.Email == email);
            if (customer == null)
            {
                return RedirectToAction("register", "home");
            }
            else
            {
                if (customer.Token != token)
                {
                    return RedirectToAction("register", "home");
                }

                HttpContext.Session.SetString("token", token);
                return View(model);
            }
        }


        [HttpPost]
        public IActionResult ResetPassword(VMResetPassword model)
        {

            model.RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList();
            model.Contacts = _context.Contacts.ToList();
            model.Subscribe = _context.Subscribe.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
           
            if (ModelState.IsValid)
            {
                if (model.Password != model.ConfirmPassword)
                {
                    ModelState.AddModelError("", "Password do not match!");
                    return View(model);
                }

                string token = HttpContext.Session.GetString("token");

                if (token == null)
                {
                    return RedirectToAction("register", "home");
                }

                Customer customer = _context.Customers.FirstOrDefault(c => c.Token == token);
                customer.Password = Crypto.HashPassword(model.Password);
                customer.Token = null;
                _context.Update(customer);
                _context.SaveChanges();
                return RedirectToAction("login", "home");
            }
            else
            {
                return View(model);
            }
        }
         public IActionResult AccessDenied()
        {
                VMBase model = new VMBase()
                {
                    RecentPosts = _context.Blog.OrderBy(o => o.Id).Take(2).ToList(),
                    Contacts = _context.Contacts.ToList(),
                    Subscribe = _context.Subscribe.FirstOrDefault(),
                    Socials = _context.Socials.ToList()
                };
          
            return View(model);
        }
    }
}


      
