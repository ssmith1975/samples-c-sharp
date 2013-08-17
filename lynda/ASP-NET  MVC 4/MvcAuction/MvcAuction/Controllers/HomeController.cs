using MvcAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAuction.Controllers
{
    public class HomeController : Controller
    {

        [AllowAnonymous]
        [OutputCache(Duration = 1)]
        public ActionResult Index()
        {
            ViewBag.Message = "This page was last rendered at " + DateTime.Now;

            return View();
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        [OutputCache(Duration = 3600)]
        public ActionResult CategoryNavigation()
        {
            var db = new AuctionsDataContext();
            var categories = db.Auctions.Select(x => x.Category).Distinct();

            ViewBag.Categories = categories.ToArray();



            return PartialView();
        }

    }
}
