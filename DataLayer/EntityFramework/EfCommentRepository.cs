using DataLayer.Abstract;
using DataLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework
{
    public class EfCommentRepository: GenericRepository<Comment>, ICommentDal
    {
    }
}
