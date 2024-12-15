using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
           
            //do not use this
            // ViewData["RandomMovie"] = movie;
            //ViewBag.Movie = movie;
            //return View();
            return View(movie);
            //return Content("Hello world!");
        }
        public ActionResult Edit(int ID)
        {
           
            return Content("id="+ID);
        }
      /*  public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby  = "Name";
            return  Content(String.Format("pageIndex={0}&sortby={1}"), pageIndex.ToString(),this);

        }*/
    }
}