using BusinessLayer.Concrete;
using DataLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class PageController : Controller
    {
        PageManager pm = new PageManager(new EfPageRepository());
        public IActionResult PageDetails(int id)
        {
            var values = pm.GetPageByID(id);
            return View(values);
        }
    }
}
