using DataLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Delete(Comment p)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment p)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment p)
        {
            throw new NotImplementedException();
        }
    }
}
