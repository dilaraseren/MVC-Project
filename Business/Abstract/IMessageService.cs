using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        List<Message> GetList();
        void MessageAdd(Message message);
        Message GetById(int id);
        void MessageDelete(Message message);

        void MessageUpdate(Message message);
    }
}
