package org.springframework.amqp.rabbit.stocks.handler;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.amqp.rabbit.stocks.gateway.RabbitMarketDataGateway;
import org.springframework.util.ErrorHandler;

public class DefaultErrorHandler implements ErrorHandler {

	private static Log logger = LogFactory.getLog(RabbitMarketDataGateway.class); 

	public void handleError(Throwable t) {
		logger.error("Could not process message", t);
		
	}

}
