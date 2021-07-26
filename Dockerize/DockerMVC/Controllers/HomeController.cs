using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DockerMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFileProvider fileProvider;
        private readonly IConfiguration _configuration;

        public HomeController(IFileProvider fileProvider, IConfiguration configuration)
        {
            this.fileProvider = fileProvider;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.MySqlCon = _configuration["MySqlCon"];
            return View();
        }

        public IActionResult ImageSave()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ImageSave(IFormFile file)
        {
            if (file!=null && file.Length>0)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

                using(var stream=new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return View();
        }


        public IActionResult GetImages()
        {
            var images = fileProvider.GetDirectoryContents("wwwroot/img").ToList().Select(i=>i.Name);

            return View(images);
        }

        [HttpPost]
        public IActionResult GetImages(string name)
        {
            var image = fileProvider.GetDirectoryContents("wwwroot/img").ToList().First(i => i.Name==name);

            System.IO.File.Delete(image.PhysicalPath);

            return RedirectToAction("GetImages");
        }
    }
}
