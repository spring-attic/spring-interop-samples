package org.springframework.amqp.rabbit.stocks.dao;

public interface TradingBookDao {

	void update(String ticker, String orderType, long quantity);

}
