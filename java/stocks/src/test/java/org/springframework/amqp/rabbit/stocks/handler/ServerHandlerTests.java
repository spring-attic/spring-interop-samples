package org.springframework.amqp.rabbit.stocks.handler;

import static org.junit.Assert.*;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.amqp.rabbit.stocks.dao.SequenceDao;
import org.springframework.amqp.rabbit.stocks.dao.TradeDao;
import org.springframework.amqp.rabbit.stocks.dao.TradingBookDao;
import org.springframework.amqp.rabbit.stocks.domain.Trade;
import org.springframework.amqp.rabbit.stocks.domain.TradeRequest;
import org.springframework.amqp.rabbit.stocks.domain.TradeResponse;
import org.springframework.aop.support.AopUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.transaction.annotation.Transactional;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration
@Transactional
public class ServerHandlerTests {

	@Autowired
	private ServerHandler serverHandler;
	
	@Autowired
	private TradeDao tradeDao;
	
	@Autowired
	private TradingBookDao tradingBookDao;
	
	@Test	
	public void testHandleMessage() {
		TradeRequest tr = new TradeRequest();
		tr.setAccountName("ACCT-123");
		tr.setBuyRequest(true);
		tr.setOrderType("MARKET");
		tr.setTicker("AAPL");
		tr.setQuantity(100);
		tr.setRequestId("REQ-1");
		tr.setUserName("Joe Trader");
		tr.setUserName("Joe");
		
		TradeResponse tradeResponse = serverHandler.handleMessage(tr);
		
		//Assert trade is in sqlfire
		Trade trade = tradeDao.findByConfirmationNumber(tradeResponse.getConfirmationNumber());	
		assertEquals(100, trade.getQuantity());
		assertTrue(trade.isBuyRequest());
		
		//Assert book is updated in gemfire
		assertEquals(100, tradingBookDao.getQuantity("AAPL"));
	}
	


}
