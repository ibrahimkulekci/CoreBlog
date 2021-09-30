using BusinessLayer.Concrete;
using DataLayer.EntityFramework;
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
        public PartialViewResult BlogDetailsAddComment()
        {
            return PartialView();
        }
        public PartialViewResult BlogDetailsListComment(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
