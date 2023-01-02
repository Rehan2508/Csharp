using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkApproach.Controllers
{
    public class HomeController : Controller
    {
        CateringContext db = new CateringContext();
        public ActionResult Index()
        {
            Session["Items"] = db.purchases.ToList().Count();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}