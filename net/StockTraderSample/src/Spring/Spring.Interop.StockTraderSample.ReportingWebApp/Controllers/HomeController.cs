using System;
using System.Data;
using System.Web.Mvc;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;
using Spring.Interop.StockTraderSample.ReportingWebApp.Repository;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TradeActivityRepository _tradeActivity;
        private readonly OutstandingSharesRepository _outstandingShares;

        public HomeController(TradeActivityRepository tradeActivity, OutstandingSharesRepository outstandingShares)
        {
            _tradeActivity = tradeActivity;
            _outstandingShares = outstandingShares;
        }

        public string Message { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = Message;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ActivityReport()
        {
            var trades = _tradeActivity.GetAllTrades();

            var tradeModel = new TradeActivityModel("Trade Activity", trades);

            return View(tradeModel);
        }

        public ActionResult OutstandingShares()
        {
            var shares = _outstandingShares.GetOutStandingShares();

            if (Request.IsAjaxRequest())
            {
                return Json(shares, JsonRequestBehavior.AllowGet);
            }

            return View(shares);
        }
    }
}
