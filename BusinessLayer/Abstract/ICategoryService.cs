using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category p);
        void DeleteCategory(Category p);
        void UpdateCategory(Category p);
        List<Category> GetList();
        Category GetById(int id);
    }
}
