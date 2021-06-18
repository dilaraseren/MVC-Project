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
    public class MessageController : Controller
    {
        // GET: Message
       MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messagelist = mm.GetListInbox();
            return View(messagelist);
        }

        public ActionResult Sendbox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var Values = mm.GetById(id);
            return View(Values);
        }
        public ActionResult GetSendboxMessageDetails(int id)
        {
            var Values = mm.GetById(id);
            return View(Values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult results = messagevalidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");

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
    }
}