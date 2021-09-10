using EduCavoFinal.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Areas.Admin
{
    [Area("admin")]
    [AuthUser]
    public class ClockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
