namespace Spring.Interop.StockTraderSample.Common.Data
{
    public class TradeFailureResponse
    {
        private readonly string _failureReason;
        private readonly string _symbol;
        private readonly Trade.OrderType _orderType;
        private readonly int _quantity;

        public TradeFailureResponse(string symbol, int quantity, string failureReason, Trade.OrderType orderType)
        {
            _symbol = symbol;
            _orderType = orderType;
            _failureReason = failureReason;
            _quantity = quantity;
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
    }
}