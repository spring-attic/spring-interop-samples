using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdoTemplate _adoTemplate;
        private readonly IRowMapper<Trade> _tradeRowMapper;

        public HomeController(AdoTemplate adoTemplate, IRowMapper<Trade> tradeRowMapper)
        {
            _adoTemplate = adoTemplate;
            _tradeRowMapper = tradeRowMapper;
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
            var sql = "select Symbol, Quantity, ExecutionPrice, Type from Trade";

            var trades = _adoTemplate.QueryWithRowMapper(CommandType.Text, sql, _tradeRowMapper);

            var tradeModel = new TradeActivityModel("Activity", trades);

            return View(tradeModel);
        }
    }

    public class TradeRowMapper : IRowMapper<Trade>
    {
        public Trade MapRow(IDataReader reader, int rowNum)
        {
            var typeString = reader.GetString(3);

            var type = typeString == "BUY" ? Trade.OrderType.BUY : Trade.OrderType.SELL;

            return new Trade(reader.GetString(0), reader.GetInt32(1), (double)reader.GetDecimal(2), type);
        }
    }
}
