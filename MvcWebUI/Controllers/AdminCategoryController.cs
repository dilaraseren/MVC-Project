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
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        [Authorize]
        public ActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(c);
            if (results.IsValid)
            {
                categoryManager.CategoryAdd(c);
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
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalues = categoryManager.GetById(id);
            categoryManager.CategoryDelete(categoryvalues);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryvalues = categoryManager.GetById(id);
            return View(categoryvalues);
        }


        [HttpPost]
        public ActionResult EditCategory(Category p )
        {
            categoryManager.CategoryUpdate(p);
            return RedirectToAction("Index");
        }
    }
}