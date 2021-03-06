using CoreBlog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public IActionResult WriterGetById(int WriterId)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == WriterId);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass {Id=1, Name="Ayşe"},
            new WriterClass {Id=2, Name="Ali"},
            new WriterClass {Id=3, Name="Veli"},
            new WriterClass {Id=4, Name="Ahmet"},
            new WriterClass {Id=5, Name="Osman"}
        };
    }
}
