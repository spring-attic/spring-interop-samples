using System.Collections.Generic;
using System.Data;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.Common.Data;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Repository
{
    public class OutstandingSharesRepository
    {
        public IEnumerable<OutstandingShares> GetOutStandingShares()
        {
            //TODO: actually get this from gemfire for real
            return new List<OutstandingShares>() { new OutstandingShares("MSFT", 200), new OutstandingShares("CSCO", 10000) };
        }
    }


}