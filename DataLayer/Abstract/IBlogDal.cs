using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        //List<Blog> ListAllBlog();
        //void AddBlog(Blog p);
        //void DeleteBlog(Blog p);
        //void UpdateBlog(Blog p);
        //Blog GetById(int id);
        //27.09.2021 14:32//

        List<Blog> GetListWithCategory(); //Sadece bloglara özel olduğu için burada tanımlandı.


    }
}
