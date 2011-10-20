namespace Spring.Interop.StockTraderSample.Common.Data
{
    public class CreditCheckRequest
    {
        private readonly string _accountName;
        private readonly decimal _purchaseValue;

        public CreditCheckRequest(string accountName, decimal purchaseValue)
        {
            _accountName = accountName;
            _purchaseValue = purchaseValue;
        }

        public decimal PurchaseValue
        {
            get { return _purchaseValue; }
        }

        public string AccountName
        {
            get { return _accountName; }
        }
    }
}