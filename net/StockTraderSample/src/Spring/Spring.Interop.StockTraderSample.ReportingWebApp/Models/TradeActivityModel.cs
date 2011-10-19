using System.Collections.Generic;

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

    public class Trade
    {
        public enum OrderType { BUY, SELL }

        private string _symbol;
        private OrderType _type;
        private long _quantity;
        private double _executionPrice;

        public Trade(string symbol, long quantity, double executionPrice, OrderType type)
        {
            _symbol = symbol;
            _type = type;
            _executionPrice = executionPrice;
            _quantity = quantity;
        }

        public OrderType Type
        {
            get { return _type; }
        }

        public long Quantity
        {
            get { return _quantity; }
        }

        public double ExecutionPrice
        {
            get { return _executionPrice; }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}