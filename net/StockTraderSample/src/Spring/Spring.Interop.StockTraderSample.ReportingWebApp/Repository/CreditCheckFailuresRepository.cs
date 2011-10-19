using System.Collections.Generic;
using System.Data;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Repository
{
    public class CreditCheckFailuresRepository
    {
        private readonly IRowMapper<CreditCheckFailure> _creditFailureRowMapper;
        private readonly AdoTemplate _adoTemplate;

        public CreditCheckFailuresRepository(AdoTemplate adoTemplate, IRowMapper<CreditCheckFailure> creditFailureRowMapper)
        {
            _adoTemplate = adoTemplate;
            _creditFailureRowMapper = creditFailureRowMapper;
        }

        public IEnumerable<CreditCheckFailure> GetAllFailures()
        {
            var sql = "select Symbol, Quantity, Failure_Reason, Type, DateTime from CreditCheckFailure";

            return _adoTemplate.QueryWithRowMapper(CommandType.Text, sql, _creditFailureRowMapper);
        }
    }

    public class CreditCheckFailureRowMapper : IRowMapper<CreditCheckFailure>
    {
        public CreditCheckFailure MapRow(IDataReader reader, int rowNum)
        {
            var typeString = reader.GetString(3);
            var type = Trade.ConvertToOrderType(typeString);

            return new CreditCheckFailure(reader.GetString(0), reader.GetInt32(1), reader.GetString(2), type, reader.GetDateTime(4));
        }
    }

}