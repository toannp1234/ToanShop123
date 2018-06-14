using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToanShop.WebApp.Extensions;

namespace ToanShop.WebApp.Areas.Admin.Controllers
{
   
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page";
            return View();
        }
    }
}