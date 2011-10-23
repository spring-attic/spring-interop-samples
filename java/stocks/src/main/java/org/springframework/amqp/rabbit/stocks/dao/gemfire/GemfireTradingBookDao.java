package org.springframework.amqp.rabbit.stocks.dao.gemfire;

import java.util.Map;

import org.springframework.amqp.rabbit.stocks.dao.TradingBookDao;

public class GemfireTradingBookDao implements TradingBookDao {

	private Map tradingBook;

	public Map getTradingBook() {
		return tradingBook;
	}

	public void setTradingBook(Map tradingBook) {
		this.tradingBook = tradingBook;
	}

	public void update(String ticker, String orderType, long quantity) {

		long totalQuantity = 0;
		if (tradingBook.containsKey(ticker)) {
			totalQuantity = (Long) tradingBook.get(ticker);
		}
		if (orderType.equalsIgnoreCase("BUY")) {
			totalQuantity = totalQuantity + quantity;
		} else {
			totalQuantity = totalQuantity - quantity;
		}
		tradingBook.put(ticker, totalQuantity);
	}

}
