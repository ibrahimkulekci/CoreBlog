using DataLayer.Abstract;
using DataLayer.Concrete;
using DataLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c=new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }                 
        }
    }
}
