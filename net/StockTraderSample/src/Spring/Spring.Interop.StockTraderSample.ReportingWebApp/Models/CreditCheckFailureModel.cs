using System.Collections.Generic;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Models
{
    public class CreditCheckFailureModel
    {
        private readonly string _title;
        private readonly IEnumerable<CreditCheckFailure> _failures;

        public CreditCheckFailureModel(string title, IEnumerable<CreditCheckFailure> failures)
        {
            _title = title;
            _failures = failures;
        }

        public IEnumerable<CreditCheckFailure> Failures
        {
            get { return _failures; }
        }

        public string Title
        {
            get { return _title; }
        }
    }
}