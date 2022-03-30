using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        
        private IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TAdd(Announcement t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new System.NotImplementedException();
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}