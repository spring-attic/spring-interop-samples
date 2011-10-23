package org.springframework.amqp.rabbit.stocks.dao.sqlfire;

import static org.junit.Assert.*;

import java.util.UUID;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.amqp.rabbit.stocks.dao.SequenceDao;
import org.springframework.amqp.rabbit.stocks.dao.TradeDao;
import org.springframework.amqp.rabbit.stocks.domain.Trade;
import org.springframework.aop.support.AopUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.transaction.annotation.Transactional;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration
@Transactional
public class DaoTests {

	@Autowired
	private SequenceDao sequenceDao;
	
	@Autowired
	private TradeDao tradeDao;
	
	@Test	
	public void testSequenceDao() {
		assertTrue("sequenceDao should be an AOP proxy", AopUtils.isAopProxy(sequenceDao));
		int firstId = sequenceDao.getNextTradeId();
		assertEquals(1000, firstId);
	}
	
	@Test
	public void testTradeDao() {
		int tradeId = sequenceDao.getNextTradeId();
		Trade trade = new Trade(tradeId, "AAPL", true, "MARKET", 100, 392.0, true, "BAD") ;
		String confirmationNumber = UUID.randomUUID().toString();
		trade.setConfirmationNumber(confirmationNumber);
		tradeDao.save(trade);
		Trade trade2 = tradeDao.findById(tradeId);
		assertEquals(tradeId, trade2.getId());			
		assertTrade(trade2);
		
		Trade trade3 = tradeDao.findByConfirmationNumber(confirmationNumber);
		assertTrade(trade3);

	}

	private void assertTrade(Trade trade2) {
			
		assertEquals(100, trade2.getQuantity());
		assertTrue(trade2.isBuyRequest());
	}
	
	

}
