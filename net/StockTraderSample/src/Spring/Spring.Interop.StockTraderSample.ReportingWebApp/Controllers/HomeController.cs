using System;
using System.Collections.Generic;
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

        public HomeController(TradeActivityRepository tradeActivity)
        {
            _tradeActivity = tradeActivity;
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

            var tradeModel = new TradeActivityModel("Activity", trades);

            return View(tradeModel);
        }
    }

  
}
