using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Concrete;
using Entities.Concrete;

namespace MvcWebUI.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        MvcContext c = new MvcContext();
        public ActionResult Index()
        {

            var deger1 = c.Categories.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Headings.Count(x => x.HeadingName == "Yazılım").ToString();
            ViewBag.d2 = deger2;
            var deger3 = (from x in c.Writers select x.WriterName.IndexOf("a")).Distinct().Count().ToString();
            ViewBag.d3 = deger3;
            var deger4 = c.Categories.Where(u => u.CategoryId == (c.Headings.GroupBy(x => x.CategoryId)
           .OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault())).Select(k => k.CategoryName).FirstOrDefault();
            ViewBag.d4 = deger4;
            var deger5 = c.Categories.Count(x => x.Status == true) - c.Categories.Count(x => x.Status == false);
            ViewBag.d5 = deger5;
            return View();
        }
    }
}