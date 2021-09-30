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
        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //27.09.2021 15:30

        //EfCategoryRepository efCategoryRepository;
        //27.09.2021 16:05        

        //public CategoryManager()
        //{
        //    efCategoryRepository = new EfCategoryRepository();
        //}
        //27.09.2021 16:05

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category p)
        {
            //efCategoryRepository.Insert(p);
            _categoryDal.Insert(p);
        }

        public void DeleteCategory(Category p)
        {
            //efCategoryRepository.Delete(p);
            _categoryDal.Delete(p);
        }

        public Category GetById(int id)
        {
            //return efCategoryRepository.GetById(id);
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            //return efCategoryRepository.GetListAll();
            return _categoryDal.GetListAll();
        }

        public void UpdateCategory(Category p)
        {
            //efCategoryRepository.Update(p);
            _categoryDal.Update(p);
        }
    }
}
