using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        MvcContext context = new MvcContext();
        DbSet<Category> _object;
        public void Delete(Category category)
        {
            _object.Remove(category);
            context.SaveChanges();
        }

        public void Insert(Category category)
        {
            _object.Add(category);
            context.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Update(Category category)
        {
            context.SaveChanges();
        }
    }
}