using System;

namespace Spring.Interop.StockTraderSample.Common.Data
{
    public class CreditCheckResponse
    {
        private readonly string _account;
        private readonly decimal _value;
        private readonly bool _passFailFail;
        private readonly string _reason;


        public CreditCheckResponse(string account, decimal value, bool passFail, string reason)
        {
            _account = account;
            _value = value;
            _passFailFail = passFail;

            if (!passFail)
            {
                _reason = reason;    
            }
            
        }


        public decimal Value
        {
            get { return _value; }
        }

        public string Account
        {
            get { return _account; }
        }

        public string Reason
        {
            get { return _reason; }
        }

        public bool PassFailFail
        {
            get { return _passFailFail; }
        }
    }
}