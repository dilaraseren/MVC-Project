using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();

        void AdminAdd(Admin admin);

        void AdminDelete(Admin admin);

        void AdminUpdate(Admin admin);

        Admin GetByAdminID(int id);

    }
}
