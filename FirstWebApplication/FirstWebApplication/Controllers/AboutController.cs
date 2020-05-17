using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Json(new { 
            //    Id=1,
            //    Name="Mubush",
            //    Surname="Memmedzade"
            //});

            //return File("~/images/ayi.jpg", "image/jpg");
        }
    }
}