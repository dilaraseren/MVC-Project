using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        MvcContext context = new MvcContext();
        DbSet<Writer> _object;
        public void Delete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer entity)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer entity)
        {
            throw new NotImplementedException();
        }
    }
}
