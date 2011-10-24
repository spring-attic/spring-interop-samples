namespace Spring.Interop.StockTraderSample.Common.Data
{
    public class Trade
    {
        private readonly string _confirmationNumber;

        private readonly string _symbol;
        private readonly long _quantity;
        private readonly decimal _executionPrice;
        private readonly bool _buyRequest;
        private readonly string _orderType;
        private readonly bool _error;
        private readonly string _errorMessage;

        public Trade(string confirmationNumber, string symbol, int quantity, decimal executionPrice, bool buyRequest, string orderType, bool error, string errorMessage)
        {
            _confirmationNumber = confirmationNumber;
            _symbol = symbol;
            _quantity = quantity;
            _executionPrice = executionPrice;
            _buyRequest = buyRequest;
            _orderType = orderType;
            _error = error;
            _errorMessage = errorMessage;
        }


        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public bool Error
        {
            get { return _error; }
        }

        public string OrderType
        {
            get { return _orderType; }
        }

        public bool BuyRequest
        {
            get { return _buyRequest; }
        }

        public decimal ExecutionPrice
        {
            get { return _executionPrice; }
        }

        public long Quantity
        {
            get { return _quantity; }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}