package org.springframework.amqp.rabbit.stocks.dao;

public interface SequenceDao {
	
		static String TRADE_SEQ = "tradenum";
		
		int getNextTradeId();
		
		int getNextId(String name);
}
