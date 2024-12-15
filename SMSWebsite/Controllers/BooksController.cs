using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SMSWebsite.Models;
using Ins = ClassLibrary.Interfaces;
using Biz = ClassLibrary.BO;
namespace SMSWebsite.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult GetData()
        {
            Book book = new Book() { Title = "Famous Five" };
            return View(book);
        }
        public ActionResult Index(int? pageIndex, string sortby)
        {
            Ins.ISubject subject = new Biz.SubjectBO().CreateSubject();

            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortby))
                sortby = " ";

            return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex,sortby));
        }
        public ActionResult BooksByName()
        {
            Book book = new Book() { Title = "Famous Five" };
            return View(book);
        }
    }
}