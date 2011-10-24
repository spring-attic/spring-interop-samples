using System.Collections.Generic;
using System.Data;
using Spring.Data.Generic;
using Spring.Interop.StockTraderSample.Common.Data;
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

        public IEnumerable<Trade> GetAllTrades()
        {
            const string selectAllTrades = "select ConfirmationNumber, Symbol, Quantity, ExecutionPrice, BuyRequest, OrderType, Error, ErrorMessage from Trade";
            return _adoTemplate.QueryWithRowMapper(CommandType.Text, selectAllTrades, _tradeRowMapper);
        }
    }

    public class TradeRowMapper : IRowMapper<Trade>
    {
        public Trade MapRow(IDataReader reader, int rowNum)
        {
            return new Trade(
                reader.GetString(0),  //confirmation number
                reader.GetString(1),  //symbol
                reader.GetInt32(2),   //quantity
                reader.GetDecimal(3), //execution price
                reader.GetBoolean(4), //buy request?
                reader.GetString(5),  //order type
                reader.GetBoolean(6), //error?
                reader.GetString(7)   //error message(s)
                );
        }
    }
}