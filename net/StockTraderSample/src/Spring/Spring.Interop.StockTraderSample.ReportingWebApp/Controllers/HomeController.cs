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
        private readonly CreditCheckFailuresRepository _creditCheckFailures;

        public HomeController(TradeActivityRepository tradeActivity, CreditCheckFailuresRepository creditCheckFailures)
        {
            _tradeActivity = tradeActivity;
            _creditCheckFailures = creditCheckFailures;
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

        public ActionResult CreditFailureReport()
        {
            var failures = _creditCheckFailures.GetAllFailures();
            var failuresModel = new CreditCheckFailureModel("Credit Check Failures",failures);

            return Json(failuresModel, JsonRequestBehavior.AllowGet);
        }
    }
}
