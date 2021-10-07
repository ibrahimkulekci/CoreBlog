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
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactRead = true;
            p.ContactStatus = true;
            cm.AddContact(p);
            return RedirectToAction("Index","Home");
        }
    }
}
