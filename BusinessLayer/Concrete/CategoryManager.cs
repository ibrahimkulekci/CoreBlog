using BusinessLayer.Abstract;
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

        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void AddCategory(Category p)
        {
            efCategoryRepository.Insert(p);
        }

        public void DeleteCategory(Category p)
        {
            efCategoryRepository.Delete(p);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }

        public void UpdateCategory(Category p)
        {
            efCategoryRepository.Update(p);
        }
    }
}
