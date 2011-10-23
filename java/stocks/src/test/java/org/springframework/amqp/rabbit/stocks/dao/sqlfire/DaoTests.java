package org.springframework.amqp.rabbit.stocks.dao.sqlfire;

import static org.junit.Assert.*;

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
		Trade trade = new Trade(tradeId, "AAPL", "BUY", 100, 392.0, true, "BAD") ;
		tradeDao.save(trade);
		Trade trade2 = tradeDao.findById(tradeId);
		assertEquals(tradeId, trade2.getId());
		assertEquals(100, trade2.getQuantity());
	}
	
	

}
