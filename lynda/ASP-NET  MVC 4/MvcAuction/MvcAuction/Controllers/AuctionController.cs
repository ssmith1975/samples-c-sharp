using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAuction.Models;
using System.Net;

namespace MvcAuction.Controllers
{
    public class AuctionController : Controller
    {
        //
        // GET: /Auction/
        [AllowAnonymous]
        [OutputCache(Duration=1)]
        public ActionResult Index()
        {
            var db = new AuctionsDataContext();
            var auctions = db.Auctions.ToArray();

            return View(auctions);
        }
        [OutputCache(Duration=10)]
        public ActionResult Auction(long id)
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(id);


            return View(auction);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(){
            var categoryList = new SelectList(new[] {"Alpha", "Beta", "Gamma", "Delta", });
            ViewBag.CategoryList = categoryList;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Exclude = "CurrentPrice")]Models.Auction auction)
        {
            if(ModelState.IsValid)
            {
                // save to the database
                var db = new AuctionsDataContext();
                

                db.Auctions.Add(auction);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bid(Bid bid) 
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(bid.AuctionId);

            if(auction == null) {
                ModelState.AddModelError("ActionId", "Auction not found!");
            } else if(auction.CurrentPrice >= bid.Amount){
                ModelState.AddModelError("Amount", "Bid amount must exceed current bid");
            } else {
                bid.Username = User.Identity.Name;
                auction.Bids.Add(bid);
                auction.CurrentPrice = bid.Amount;
                db.SaveChanges();
            }

            if(!Request.IsAjaxRequest())
                return RedirectToAction("Auction", new {id = bid.AuctionId});

           // Send JSOn response
           return Json(new {
                CurrentPrice = bid.Amount.ToString("C"),
                BidCount = auction.BidCount
            });
        }

        public ActionResult TempDataDemo()
        {
            TempData["SuccessMessage"] = "The action successed!";
            return RedirectToAction("Index");
        }

    }
}
