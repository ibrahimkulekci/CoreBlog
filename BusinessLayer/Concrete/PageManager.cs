using BusinessLayer.Abstract;
using DataLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PageManager: IPageService
    {
        IPageDal _pageDal;

        public PageManager(IPageDal pageDal)
        {
            _pageDal = pageDal;
        }

        public List<Page> GetPageByID(int id)
        {
            return _pageDal.GetListAll(x => x.PageID == id);
        }

        public List<Page> GetList()
        {
            return _pageDal.GetListAll();
        }
    }
}
