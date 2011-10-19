using System;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Models
{
    public class CreditCheckFailure
    {
        private readonly DateTime _dateTime;
        private readonly string _failureReason;
        private readonly string _symbol;
        private readonly Trade.OrderType _type;
        private readonly int _quantity;

        public CreditCheckFailure(string symbol, int quantity, string failureReason, Trade.OrderType type, DateTime dateTime)
        {
            _symbol = symbol;
            _dateTime = dateTime;
            _type = type;
            _failureReason = failureReason;
            _quantity = quantity;
        }

        public DateTime DateTime1
        {
            get { return _dateTime; }
        }

        public Trade.OrderType Type1
        {
            get { return _type; }
        }

        public string FailureReason
        {
            get { return _failureReason; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}