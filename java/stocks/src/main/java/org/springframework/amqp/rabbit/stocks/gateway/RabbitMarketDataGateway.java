/*
 * Copyright 2002-2010 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package org.springframework.amqp.rabbit.stocks.gateway;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.amqp.rabbit.core.support.RabbitGatewaySupport;
import org.springframework.amqp.rabbit.stocks.domain.MockStock;
import org.springframework.amqp.rabbit.stocks.domain.Quote;
import org.springframework.amqp.rabbit.stocks.domain.Stock;
import org.springframework.amqp.rabbit.stocks.domain.StockExchange;

/**
 * Rabbit implementation of the {@link MarketDataGateway} for sending Market data.
 * 
 * @author Mark Pollack
 * @author Mark Fisher
 */
public class RabbitMarketDataGateway extends RabbitGatewaySupport implements MarketDataGateway {

	static final Random random = new Random();
	
	private static Log logger = LogFactory.getLog(RabbitMarketDataGateway.class); 


	public RabbitMarketDataGateway() {

	}


	public void sendMarketData() {
		Quote quote = generateFakeQuote();
		Stock stock = quote.getStock();
		logger.info("Sending Market Data for " + stock.getTicker());
		String routingKey = "app.stock.quotes."+ stock.getStockExchange() + "." + stock.getTicker();
		getRabbitTemplate().convertAndSend(routingKey, quote);
	}

	private Quote generateFakeQuote() {
		MockStock stock = MockStock.stocks.get(random.nextInt(MockStock.stocks.size()));
		String price = stock.randomPriceAsString();  
		return new Quote(stock, price);
	}

}
