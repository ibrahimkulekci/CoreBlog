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
    public class WriterManager: IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Writer p)
        {
            _writerDal.Insert(p);
        }

        public void TDelete(Writer p)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public void TUpdate(Writer p)
        {
            _writerDal.Update(p);
        }
    }
}
