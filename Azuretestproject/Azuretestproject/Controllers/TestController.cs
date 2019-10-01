using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Azuretestproject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Azuretestproject.Controllers
{
   
    public class TestController : Controller
    {
        private IConfiguration config;
        private string StorageConnectionString { get; }
        private readonly IImageService imageService;

        public TestController(IImageService imageService, IConfiguration config)
        {
            StorageConnectionString = config["StorageConnectionString"];
            this.imageService = imageService;
            this.config = config;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/upload")]
        public async Task<IActionResult> Upload(IFormFileCollection files)
        {
            await imageService.UploadAsync(files);       
            return RedirectToAction("Index");
        }
    }
}