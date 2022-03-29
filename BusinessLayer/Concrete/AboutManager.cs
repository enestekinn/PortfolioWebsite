using System.Collections.Generic;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IGenericService<About>
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }
        

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }
    }
}