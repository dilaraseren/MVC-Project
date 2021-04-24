using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICategoryDal
    {
        List<Category> List();

        void Insert(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
