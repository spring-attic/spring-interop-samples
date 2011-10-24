package org.springframework.amqp.rabbit.stocks.service;

import java.util.List;

import org.springframework.amqp.rabbit.stocks.domain.CreditCheckResponse;
import org.springframework.amqp.rabbit.stocks.domain.MockStock;
import org.springframework.amqp.rabbit.stocks.domain.TradeRequest;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.client.RestTemplate;

public class DefaultCreditCheckService implements CreditCheckService {

	@Autowired
	private RestTemplate restTemplate;

	public boolean canExecute(TradeRequest tradeRequest, List<String> errors) {

		if (tradeRequest.isBuyRequest()) {
			double purchasePrice = calculatePurchasePrice(tradeRequest);
			CreditCheckResponse response = restTemplate.getForObject(
					"http://localhost:1100/home/CreditCheck/?accountname={0}&purchasevalue={1}", CreditCheckResponse.class,
					tradeRequest.getAccountName(), purchasePrice);

			// if failed credit check
			if (!response.isPassFail()) {
				errors.add(response.getReason());
				return false;
			}
		}
		return true;
	}

	private double calculatePurchasePrice(TradeRequest tradeRequest) {
		MockStock stock = MockStock.getStockByName(tradeRequest.getTicker());
		double purchasePrice = Double.MAX_VALUE;
		if (stock != null) {
			purchasePrice = tradeRequest.getQuantity() * stock.randomPrice();
		}
		return purchasePrice;
	}

}
