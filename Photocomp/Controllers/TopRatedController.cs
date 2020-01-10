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
            DisplayDataFromAPI();
            return View();
        }
        private void DisplayDataFromAPI()
        {
            PictureAndMetaData PAMD = CallTopRatedIMage();

            ViewBag.PictureURL = PAMD.url;
            ViewBag.Author = PAMD.author;
            ViewBag.NameOfPic = PAMD.name;
            ViewBag.License = PAMD.license;
            ViewBag.ID = PAMD.id;
        }

        private static PictureAndMetaData CallTopRatedIMage()
        {
            var api = new API();
            PictureAndMetaData PAMD = new PictureAndMetaData();
            PAMD = api.SelectRightCommand(4);
            return PAMD;
        }
    }
}