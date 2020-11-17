using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veedfrnd.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult index() {
            return View();
        }
        public ViewResult ContactUs() {
            return View();
        }
        public ViewResult AboutUs() {
            return View();
        }
    }
}
