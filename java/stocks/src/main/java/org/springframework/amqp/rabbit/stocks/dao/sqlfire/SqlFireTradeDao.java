package org.springframework.amqp.rabbit.stocks.dao.sqlfire;

import javax.sql.DataSource;

import org.springframework.amqp.rabbit.stocks.dao.TradeDao;
import org.springframework.amqp.rabbit.stocks.domain.Trade;
import org.springframework.amqp.rabbit.stocks.generated.domain.QTrade;
import org.springframework.data.jdbc.query.QueryDslJdbcTemplate;
import org.springframework.data.jdbc.query.SqlInsertCallback;
import org.springframework.jdbc.core.BeanPropertyRowMapper;
import org.springframework.transaction.annotation.Transactional;

import com.mysema.query.sql.SQLQuery;
import com.mysema.query.sql.dml.SQLInsertClause;

@Transactional
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
					.values(trade.getId(), trade.getSymbol(), trade.getOrdertype(), trade.getQuantity(), trade.getExecutionPrice(), trade.getError(), trade.getErrorMessage()).execute();
				
			}
		});
	}

	public Trade findById(int id) {
		SQLQuery sqlQuery = template.newSqlQuery()
				.from(qTrade)
				.where(qTrade.id.eq(id));		
			return template.queryForObject(sqlQuery, 
				BeanPropertyRowMapper.newInstance(Trade.class), 
				qTrade.all());
	}

}
