using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Http;

namespace VD.Controllers
{
    public class GalleryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
            if (Directory.GetFiles("wwwroot/galleryImages").Length != 0)
            {
                List<string> Images = new List<string>();
                foreach (var img in Directory.GetFiles("wwwroot/galleryImages")) //wwwroot / galleryImages\1.jpg
                {
                    Images.Add(img.Substring(8));
                }
                return View(Images);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file) {

            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/galleryImages",file.FileName);
            using (var fs = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string path)
        {
            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot",path));
            return RedirectToAction("Index");
        }

    }
}