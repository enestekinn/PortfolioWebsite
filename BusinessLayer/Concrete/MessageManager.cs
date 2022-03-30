using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);

        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetListByFilter()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Message t)
        {

        }


    }
}