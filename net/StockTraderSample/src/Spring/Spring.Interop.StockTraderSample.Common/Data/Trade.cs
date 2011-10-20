namespace Spring.Interop.StockTraderSample.Common.Data
{
    public class Trade
    {
        public enum OrderType { BUY, SELL }

        private readonly string _symbol;
        private readonly OrderType _type;
        private readonly long _quantity;
        private readonly double _executionPrice;

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

        public static Trade.OrderType ConvertToOrderType(string orderTypeString)
        {
            return orderTypeString.ToUpper() == "BUY" ? Trade.OrderType.BUY : Trade.OrderType.SELL;
        }
    }
}