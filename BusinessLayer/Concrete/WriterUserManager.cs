using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        private IWriterUserDal _writerUserDal;
        

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void TAdd(WriterUser t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(WriterUser t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(WriterUser t)
        {
            throw new System.NotImplementedException();
        }

        public List<WriterUser> TGetList()
        {
            return _writerUserDal.GetList();
        }

        public WriterUser TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<WriterUser> TGetListByFilter()
        {
            throw new System.NotImplementedException();
        }
    }
}