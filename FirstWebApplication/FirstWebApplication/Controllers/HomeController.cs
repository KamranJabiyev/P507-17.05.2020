using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            return View();
            //ViewResult view = new ViewResult();
            //view.ViewName = "Index";
            //return view;
        }

        public ViewResult Test()
        {
            return View();
        }
    }
}
