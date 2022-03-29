using System.Collections.Generic;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IGenericService<Contact>
    {

        private IContactDal _contactDalDal;

        public ContactManager(IContactDal contactDalDal)
        {
            _contactDalDal = contactDalDal;
        }

        public void TAdd(Contact t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            _contactDalDal.Update(t);
        }

        public List<Contact> TGetList()
        {
            return _contactDalDal.GetList();
        }

        public Contact TGetById(int id)
        {
            return  _contactDalDal.GetById(id);
        }
    }
}