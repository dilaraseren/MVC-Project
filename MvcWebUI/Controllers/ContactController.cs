using Business.Concrete;
using Business.ValidationRules.FluentValidation;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetById(id);
            return View(contactValues);
        }
        //public PartialViewResult ContactSideBarPartial()
        //{
        //    var contact = cm.GetList().Count();
        //    ViewBag.contact = contact;

        //    var sendMail = messageManager.GetMessageSendBox().Count();
        //    ViewBag.sendMail = sendMail;

        //    var receiverMail = messageManager.GetMessagesInbox().Count();
        //    ViewBag.receiverMail = receiverMail;

        //    var draftMail = messageManager.GetMessageSendBox().Where(m => m.IsDraft == true).Count();
        //    ViewBag.draftMail = draftMail;

        //    var readMessage = messageManager.GetMessagesInbox().Where(m => m.IsRead == true).Count();
        //    ViewBag.readMessage = readMessage;

        //    var unreadMessage = messageManager.GetAllRead().Count();
        //    ViewBag.unreadMessage = unreadMessage;
        //    return PartialView();
        //}
    }
}