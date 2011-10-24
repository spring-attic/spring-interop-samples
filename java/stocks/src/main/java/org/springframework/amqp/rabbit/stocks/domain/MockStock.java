package org.springframework.amqp.rabbit.stocks.domain;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import org.springframework.amqp.rabbit.stocks.gateway.RabbitMarketDataGateway;

public class MockStock extends Stock {

	static final Random random = new Random();
	
	private final int basePrice;
	private final DecimalFormat twoPlacesFormat = new DecimalFormat("0.00");
	
	public final static List<MockStock> stocks = new ArrayList<MockStock>();
	
	static {
		stocks.add(new MockStock("AAPL", StockExchange.nasdaq, 255));
		stocks.add(new MockStock("CSCO", StockExchange.nasdaq, 22));
		stocks.add(new MockStock("DELL", StockExchange.nasdaq, 15));
		stocks.add(new MockStock("GOOG", StockExchange.nasdaq, 500));
		stocks.add(new MockStock("INTC", StockExchange.nasdaq, 22));
		stocks.add(new MockStock("MSFT", StockExchange.nasdaq, 29));
		stocks.add(new MockStock("ORCL", StockExchange.nasdaq, 24));
		stocks.add(new MockStock("CAJ", StockExchange.nyse, 43));
		stocks.add(new MockStock("F", StockExchange.nyse, 12));
		stocks.add(new MockStock("GE", StockExchange.nyse, 18));
		stocks.add(new MockStock("HMC", StockExchange.nyse, 32));
		stocks.add(new MockStock("HPQ", StockExchange.nyse, 48));
		stocks.add(new MockStock("IBM", StockExchange.nyse, 130));
		stocks.add(new MockStock("TM", StockExchange.nyse, 76));
	}

	public MockStock(String ticker, StockExchange stockExchange, int basePrice) {
		super(stockExchange, ticker);
		this.basePrice = basePrice;
	}

	public String randomPriceAsString() {
		return this.twoPlacesFormat.format(this.basePrice + Math.abs(random.nextGaussian()));
	}
	
	public double randomPrice() {
		return this.basePrice + Math.abs(random.nextGaussian());
	}
	
	public static MockStock getStockByName(String name) {
			for (MockStock stock : stocks) {
				if (stock.getTicker().equalsIgnoreCase(name)) {
					return stock;
				}
			}
			return null;
	}
}