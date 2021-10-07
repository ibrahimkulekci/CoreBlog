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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult BlogDetailsAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult BlogDetailsAddComment(Comment p)
        {
            p.CommentCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 2;
            cm.AddComment(p);
            return PartialView();
        }
        public PartialViewResult BlogDetailsListComment(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
