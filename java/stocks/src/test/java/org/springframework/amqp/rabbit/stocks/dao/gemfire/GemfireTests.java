package org.springframework.amqp.rabbit.stocks.dao.gemfire;

import static org.junit.Assert.*;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.amqp.rabbit.stocks.dao.TradingBookDao;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.transaction.annotation.Transactional;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration
@Transactional("gemfire-tx-manager")
public class GemfireTests {


	@Autowired
	private TradingBookDao tradingBookDao;
	

	@Test
	public void testTradingBookDao() {
		tradingBookDao.update("AAPL", true, 100);
		assertEquals(100, tradingBookDao.getQuantity("AAPL"));
	}

}
