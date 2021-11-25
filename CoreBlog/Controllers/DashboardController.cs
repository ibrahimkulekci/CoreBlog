using BusinessLayer.Concrete;
using DataLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            ViewBag.ToplamBlogSayisi = blogManager.GetList().Count();
            ViewBag.YazarinBlogSayisi = blogManager.GetBlogListWithWriter(1).Count();
            ViewBag.KategoriSayisi = categoryManager.GetList().Count();

            return View();
        }
    }
}
