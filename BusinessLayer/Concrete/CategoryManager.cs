using BusinessLayer.Abstract;
using DataLayer.Abstract;
using DataLayer.EntityFramework;
using DataLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TAdd(Category p)
        {
            _categoryDal.Insert(p);
        }

        public void TDelete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public void TUpdate(Category p)
        {
            _categoryDal.Update(p);
        }
    }
}
