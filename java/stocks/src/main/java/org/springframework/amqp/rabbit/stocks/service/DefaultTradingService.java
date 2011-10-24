package org.springframework.amqp.rabbit.stocks.service;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.amqp.rabbit.stocks.dao.SequenceDao;
import org.springframework.amqp.rabbit.stocks.dao.TradeDao;
import org.springframework.amqp.rabbit.stocks.dao.TradingBookDao;
import org.springframework.amqp.rabbit.stocks.domain.Trade;
import org.springframework.amqp.rabbit.stocks.domain.TradeRequest;
import org.springframework.amqp.rabbit.stocks.domain.TradeResponse;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.util.StringUtils;

public class DefaultTradingService implements TradingService {


	private static Log logger = LogFactory.getLog(DefaultTradingService.class);
	@Autowired
	private SequenceDao sequenceDao;

	@Autowired
	private TradeDao tradeDao;

	@Autowired
	private TradingBookDao tradingBookDao;

	@Transactional
	public void processTrade(TradeRequest request, TradeResponse response) {
		int tradeId = sequenceDao.getNextTradeId();
		
		// put invalid trades into a separate table.
		Trade trade = new Trade(tradeId, response.getTicker(), response.getBuyRequest(), response.getOrderType(), response.getQuantity(), 
					response.getPrice().doubleValue(), response.isError(), response.getErrorMessage());
		if (StringUtils.hasText(response.getConfirmationNumber())) {
			trade.setConfirmationNumber(response.getConfirmationNumber());
		}
		
		
		tradeDao.save(trade);
		if (!response.isError()) {
			tradingBookDao.update(response.getTicker(), response.getBuyRequest(), response.getQuantity());
		} else {
			logger.info("Did not update Gemfire Cache, TradeResponse has an error.  " + trade);
		}

	}

}
