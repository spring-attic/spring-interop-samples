using System.Collections.Generic;
using Spring.Interop.StockTraderSample.Common.Data;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Models
{
    public class TradeActivityModel
    {
        private readonly string _title;
        private IEnumerable<Trade> _trades = new List<Trade>();

        public TradeActivityModel(string title, IEnumerable<Trade> trades)
        {
            _title = title;
            _trades = trades;
        }

        public string Title
        {
            get { return _title; }
        }

        public IEnumerable<Trade> Trades
        {
            get { return _trades; }
        }
    }
}