using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment p);
        //void DeleteComment(Comment p);
        //void UpdateComment(Comment p);
        List<Comment> GetList(int id);
        //Comment GetById(int id);
    }
}

