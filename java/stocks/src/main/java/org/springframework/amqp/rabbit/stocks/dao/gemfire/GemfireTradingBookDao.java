package org.springframework.amqp.rabbit.stocks.dao.gemfire;

import java.util.Map;

import org.springframework.amqp.rabbit.stocks.dao.TradingBookDao;
import org.springframework.transaction.annotation.Transactional;

@Transactional("gemfire-tx-manager")
public class GemfireTradingBookDao implements TradingBookDao {

	private Map tradingBook;

	public Map getTradingBook() {
		return tradingBook;
	}

	public void setTradingBook(Map tradingBook) {
		this.tradingBook = tradingBook;
	}
	
	public long getQuantity(String ticker) {
		if (tradingBook.containsKey(ticker)) {
			return (Long) tradingBook.get(ticker);
		} 
		return Long.MIN_VALUE;
			
	}

	public void update(String ticker, boolean buyRequest, long quantity) {

		long totalQuantity = 0;
		if (tradingBook.containsKey(ticker)) {
			totalQuantity = (Long) tradingBook.get(ticker);
		}
		if (buyRequest) {
			totalQuantity = totalQuantity + quantity;
		} else {
			totalQuantity = totalQuantity - quantity;
		}
		tradingBook.put(ticker, totalQuantity);
	}

}
