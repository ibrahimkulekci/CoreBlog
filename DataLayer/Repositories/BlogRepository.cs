using DataLayer.Abstract;
using DataLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();

        public void AddBlog(Blog p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog p)
        {
            c.Update(p);
            c.SaveChanges();
        }
    }
}
