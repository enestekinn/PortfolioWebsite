using System.Collections.Generic;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Abstract
{
    public interface IWriterMessageService : IGenericService<WriterMessage>
    {
        List<WriterMessage> GetListSenderMessage(string p);
        List<WriterMessage> GetListReceiverMessage(string p);
        

    }
}