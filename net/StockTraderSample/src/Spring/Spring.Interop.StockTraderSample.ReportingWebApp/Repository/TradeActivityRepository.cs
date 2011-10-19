using System.Collections.Generic;
using System.Data;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.ReportingWebApp.Models;

namespace Spring.Interop.StockTraderSample.ReportingWebApp.Repository
{
    public class TradeActivityRepository
    {
        private readonly IRowMapper<Trade> _tradeRowMapper;
        private readonly AdoTemplate _adoTemplate;

        public TradeActivityRepository(AdoTemplate adoTemplate, IRowMapper<Trade> tradeRowMapper)
        {
            _adoTemplate = adoTemplate;
            _tradeRowMapper = tradeRowMapper;
        }

        public IEnumerable<Trade> GetAllTrades( )
        {
            var sql = "select Symbol, Quantity, ExecutionPrice, Type from Trade";

            return _adoTemplate.QueryWithRowMapper(CommandType.Text, sql, _tradeRowMapper);
        }
    }

    public class TradeRowMapper : IRowMapper<Trade>
    {
        public Trade MapRow(IDataReader reader, int rowNum)
        {
            var typeString = reader.GetString(3);
            var type = Trade.ConvertToOrderType(typeString);
            
            return new Trade(reader.GetString(0), reader.GetInt32(1), (double)reader.GetDecimal(2), type);
        }
    }
}