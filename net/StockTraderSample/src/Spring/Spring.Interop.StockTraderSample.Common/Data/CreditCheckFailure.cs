using System;

namespace Spring.Interop.StockTraderSample.Common.Data
{
    public class CreditCheckFailure
    {
        private readonly DateTime _failureDateTime;
        private readonly string _failureReason;
        private readonly string _symbol;
        private readonly Trade.OrderType _orderType;
        private readonly int _quantity;

        public CreditCheckFailure(string symbol, int quantity, string failureReason, Trade.OrderType orderType, DateTime failureDateTime)
        {
            _symbol = symbol;
            _failureDateTime = failureDateTime;
            _orderType = orderType;
            _failureReason = failureReason;
            _quantity = quantity;
        }

        public DateTime FailureDateTime
        {
            get { return _failureDateTime; }
        }

        public Trade.OrderType OrderOrderType
        {
            get { return _orderType; }
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

        public override string ToString()
        {
            return string.Format("SYM: {0} | Qty: {1} | {2} | {3} | {4}", Symbol, Quantity, FailureDateTime.ToString().ToLower(), OrderOrderType, FailureReason);
        }
    }
}