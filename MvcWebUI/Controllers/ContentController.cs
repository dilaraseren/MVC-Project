﻿using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ContentByHeading(int id)
        {

            var contentvalues = cm.GetListByHeadingId(id);
            return View(contentvalues);
        }
    }

}