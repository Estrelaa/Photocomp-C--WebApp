using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Photocomp.Controllers
{
    public class TopRatedController : Controller
    {
        public IActionResult TopImage()
        {
            return View();
        }
    }
}