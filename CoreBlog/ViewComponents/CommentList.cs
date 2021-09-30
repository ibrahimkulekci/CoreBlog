using CoreBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<CommentUser>
            {
                new CommentUser
                {
                    ID=1,
                    Username="İbrahim"
                },
                new CommentUser
                {
                    ID=2,
                    Username="Mesut"
                },
                new CommentUser
                {
                    ID=3,
                    Username="Merve"
                }
            };
            return View(commentvalues);
        }
    }
}
