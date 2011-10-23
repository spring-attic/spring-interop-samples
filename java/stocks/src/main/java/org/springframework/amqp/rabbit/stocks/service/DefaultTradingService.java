package org.springframework.amqp.rabbit.stocks.service;

import org.springframework.amqp.rabbit.stocks.dao.SequenceDao;
import org.springframework.amqp.rabbit.stocks.dao.TradeDao;
import org.springframework.amqp.rabbit.stocks.dao.TradingBookDao;
import org.springframework.amqp.rabbit.stocks.domain.Trade;
import org.springframework.amqp.rabbit.stocks.domain.TradeRequest;
import org.springframework.amqp.rabbit.stocks.domain.TradeResponse;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.transaction.annotation.Transactional;

public class DefaultTradingService implements TradingService {

	@Autowired
	private SequenceDao sequenceDao;

	@Autowired
	private TradeDao tradeDao;

	@Autowired
	private TradingBookDao tradingBookDao;

	@Transactional
	public void processTrade(TradeRequest request, TradeResponse response) {
		int tradeId = sequenceDao.getNextTradeId();
		
		Trade trade = new Trade(tradeId, response.getTicker(), response.getOrderType(), response.getQuantity(), 
					response.getPrice().doubleValue(), response.isError(), response.getErrorMessage());
		
		tradeDao.save(trade);
		if (!response.isError()) {
			tradingBookDao.update(response.getTicker(), response.getOrderType(), response.getQuantity());
		}

	}

}
