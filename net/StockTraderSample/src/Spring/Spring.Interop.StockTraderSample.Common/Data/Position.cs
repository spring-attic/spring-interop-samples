namespace Spring.Interop.StockTraderSample.Common.Data
{
    public class Position
    {
        private readonly string _symbol;
        private readonly int _shares;

        public Position(string symbol, int shares)
        {
            _symbol = symbol;
            _shares = shares;
        }

        public int Shares
        {
            get { return _shares; }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}