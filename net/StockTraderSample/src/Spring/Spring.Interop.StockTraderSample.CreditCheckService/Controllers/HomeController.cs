using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Spring.Interop.StockTraderSample.Common.Data;

namespace Spring.Interop.StockTraderSample.CreditCheckService.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<string> _failureReasons = new List<string>()
                                                          {
                                                              "Insufficient Funds.",
                                                              "I don't like you very much.",
                                                              "We don't serve your kind here.",
                                                              "Get out of my sight and don't come back!"
                                                          };

        public string Message { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = Message;

            return View();
        }

        public ActionResult CreditCheck(string accountName, decimal purchaseValue)
        {
            var response = AssembleRandomCreditCheckResponse(accountName, purchaseValue);
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        private CreditCheckResponse AssembleRandomCreditCheckResponse(string account, decimal purchaseValue)
        {
            var rnd = new Random();
            var reasonIndex = rnd.Next(0, _failureReasons.Count() - 1);
            var passFail = rnd.Next(1, 100) % 5.0 == 0 ? false : true;

            return new CreditCheckResponse(account, purchaseValue, passFail, _failureReasons.ElementAt(reasonIndex));
        }
    }
}
