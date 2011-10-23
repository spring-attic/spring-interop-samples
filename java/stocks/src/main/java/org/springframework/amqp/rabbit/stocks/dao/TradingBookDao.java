package org.springframework.amqp.rabbit.stocks.dao;

public interface TradingBookDao {

	long getQuantity(String ticker);
	
	void update(String ticker, boolean buyRequest, long quantity);

}
