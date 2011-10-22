package org.springframework.amqp.rabbit.stocks.service;

import org.springframework.amqp.rabbit.stocks.dao.TradeDao;
import org.springframework.amqp.rabbit.stocks.domain.TradeRequest;
import org.springframework.amqp.rabbit.stocks.domain.TradeResponse;
import org.springframework.beans.factory.annotation.Autowired;

public class DefaultTradingService implements TradingService {

	@Autowired
	private TradeDao stockDao;
	
	public void processTrade(TradeRequest request, TradeResponse response) {
		// TODO Auto-generated method stub

	}

}
