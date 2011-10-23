package org.springframework.amqp.rabbit.stocks.dao.sqlfire;

import java.math.BigDecimal;

import javax.sql.DataSource;

import org.springframework.amqp.rabbit.stocks.dao.TradeDao;
import org.springframework.amqp.rabbit.stocks.domain.Trade;
import org.springframework.amqp.rabbit.stocks.generated.domain.QTrade;
import org.springframework.data.jdbc.query.QueryDslJdbcTemplate;
import org.springframework.data.jdbc.query.SqlInsertCallback;
import org.springframework.jdbc.core.BeanPropertyRowMapper;
import org.springframework.transaction.annotation.Transactional;

import com.mysema.query.Tuple;
import com.mysema.query.sql.SQLQuery;
import com.mysema.query.sql.dml.SQLInsertClause;
import com.mysema.query.types.Expression;
import com.mysema.query.types.MappingProjection;

@Transactional()
public class SqlFireTradeDao implements TradeDao {

	private final QTrade qTrade = QTrade.trade;

	private QueryDslJdbcTemplate template;

	public void setDataSource(DataSource dataSource) {
		this.template = new QueryDslJdbcTemplate(dataSource);
	}

	public void save(final Trade trade) {
		template.insert(qTrade, new SqlInsertCallback() {

			public long doInSqlInsertClause(SQLInsertClause insertClause) {
				
				return insertClause.columns(qTrade.id, qTrade.symbol, qTrade.ordertype, qTrade.quantity, qTrade.executionprice, qTrade.error, qTrade.errormessage)
					.values(trade.getId(), trade.getSymbol(), trade.getOrdertype(), trade.getQuantity(), trade.getExecutionPrice(), trade.isError() ? "T" : "F", trade.getErrorMessage()).execute();
				
			}
		});
	}

	public Trade findById(int id) {
		SQLQuery sqlQuery = template.newSqlQuery()
				.from(qTrade)
				.where(qTrade.id.eq(id));		
			return template.queryForObject(sqlQuery,  new MappingTradeProjection(qTrade.all()));
	}
	
	private class MappingTradeProjection extends MappingProjection<Trade> {
		
		public MappingTradeProjection(Expression<?>... args) {
			super(Trade.class, args);
		}

		@Override
		protected Trade map(Tuple tuple) {
			Trade trade = new Trade();
			
			String errorFlag = tuple.get(qTrade.error);
			if (errorFlag.equalsIgnoreCase("T")) { 
				trade.setError(true);
				trade.setErrorMessage(tuple.get(qTrade.errormessage));
			}
			
			
			trade.setExecutionPrice(tuple.get(qTrade.executionprice).doubleValue());
			trade.setId(tuple.get(qTrade.id));
			trade.setOrdertype(tuple.get(qTrade.ordertype));
			trade.setQuantity(tuple.get(qTrade.quantity));
			trade.setSymbol(tuple.get(qTrade.symbol));
			
			return trade;
		}
	}
	

}
