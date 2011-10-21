using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;
using Spring.Interop.StockTraderSample.ReportingWebApp.Repository;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TradeActivityRepository _tradeActivity;
        private readonly PositionRepository _position;

        public HomeController(TradeActivityRepository tradeActivity, PositionRepository position)
        {
            _tradeActivity = tradeActivity;
            _position = position;
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

        public ActionResult Position()
        {
            var shares = _position.GetAllShares();

            if (Request.AcceptTypes.Any(rt => rt == "application/json"))
            {
                return Json(shares, JsonRequestBehavior.AllowGet);
            }

            return View(shares);
        }
    }
}
