using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }

        public List<Message> GetIsDraft()
        {
            return _messageDal.List(m => m.IsDraft == true);
        }

        public List<Message> GetReadList()
        {
            return _messageDal.List(x => x.IsRead == true && x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetUnReadList()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com" && x.IsRead == false);
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public List<Message> GetTrash()
        {

            return _messageDal.List(x => x.Trash == true);
        }

        public void MessageAdd(Message message)
        {

            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            _messageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
