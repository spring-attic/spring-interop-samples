using System.Collections.Generic;
using System.Web.Mvc;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Controllers
{
    public class HomeController : Controller
    {

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
            var trades = new List<Trade>()
                             {
                                 new Trade("MSFT", 1, 1.0, Trade.OrderType.BUY),
                                 new Trade("CSCO", 2, 1.5, Trade.OrderType.BUY),
                                 new Trade("GOOG", 15, 35.45, Trade.OrderType.BUY),
                                 new Trade("APPL", 12, 225.23, Trade.OrderType.BUY),
                             };
            TradeActivityModel tradeModel = new TradeActivityModel("Activity", trades);

            return View(tradeModel);
        }
    }
}
