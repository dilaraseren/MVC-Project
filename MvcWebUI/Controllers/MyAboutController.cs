using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class MyAboutController : Controller
    {
        MyAboutManager abm = new MyAboutManager(new EfMyAboutDal());
        // GET: MyAbout
        public ActionResult Index()
        {
            var about = abm.GetList();
            return View(about);
        }
    }
}