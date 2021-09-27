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
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        //
        public void AddCategory(Category p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public void DeleteCategory(Category p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }

        public void UpdateCategory(Category p)
        {
            c.Update(p);
            c.SaveChanges();
        }
    }
}
