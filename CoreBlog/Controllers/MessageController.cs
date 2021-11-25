using BusinessLayer.Concrete;
using DataLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IActionResult Inbox()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult MessageDetails(Message2 p)
        {
            return View();
        }
    }
}
