using System.Collections.Generic;
using System.Data;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.Common.Data;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Repository
{
    public class PositionRepository
    {
        public IEnumerable<Position> GetAllShares()
        {
            //TODO: actually get this from gemfire for real
            return new List<Position>() { new Position("MSFT", 200), new Position("CSCO", 10000) };
        }
    }


}