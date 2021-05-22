using Business.Concrete;
using Business.ValidationRules.FluentValidation;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        WriterValidator writerValidator = new WriterValidator();
        public ActionResult Index()
        {
            var values = writerManager.GetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }


        public ActionResult AddWriter(Writer writer)
        {

            ValidationResult results = writerValidator.Validate(writer);
            if (results.IsValid)
            {
                writerManager.WriterAdd(writer);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var i in results.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);

                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writervalue = writerManager.GetById(id);
            return View(writervalue);

        }

    
        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {
            ValidationResult results = writerValidator.Validate(p);
            if (results.IsValid)
            {
                writerManager.WriterUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}