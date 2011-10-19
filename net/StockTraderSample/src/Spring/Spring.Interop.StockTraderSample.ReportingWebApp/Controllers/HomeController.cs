using System.Web.Mvc;

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
    }
}
