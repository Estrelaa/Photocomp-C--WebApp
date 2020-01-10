using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Photocomp.Models;

namespace Photocomp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DisplayDataFromAPI();

            return View();
        }
        [HttpPost]
        public ActionResult SendVoteUp(int ID)
        {
            var api = new API();
            api.SelectRightCommand(5, ID);
            DisplayDataFromAPI();

            return View("Index");
        }
        [HttpPost]
        public ActionResult SendVoteDown(int ID)
        {
            var api = new API();
            api.SelectRightCommand(6, ID);
            DisplayDataFromAPI();

            return View("Index");
        }
        private void DisplayDataFromAPI()
        {
            PictureAndMetaData PAMD = CallRandomImage();

            ViewBag.PictureURL = PAMD.url;
            ViewBag.Author = PAMD.author;
            ViewBag.NameOfPic = PAMD.name;
            ViewBag.License = PAMD.license;
            ViewBag.ID = PAMD.id;
        }

        private static PictureAndMetaData CallRandomImage()
        {
            var api = new API();
            PictureAndMetaData PAMD = new PictureAndMetaData();
            PAMD = api.SelectRightCommand(3);
            return PAMD;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
