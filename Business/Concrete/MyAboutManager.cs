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
    public class MyAboutManager : IMyAboutService
    {
        IMyAboutDal _myaboutDal;

        public MyAboutManager(IMyAboutDal myaboutDal)
        {
            _myaboutDal = myaboutDal;
        }

        public List<MyAbout> GetList()
        {
            return _myaboutDal.List();
        }
    }
}
