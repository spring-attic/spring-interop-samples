package org.springframework.amqp.rabbit.stocks.domain;

public class CreditCheckRequest {

	private String accountName;
	
	private double purchaseValue;

	public CreditCheckRequest(String accountName, double purchaseValue) {
		super();
		this.accountName = accountName;
		this.purchaseValue = purchaseValue;
	}

	public String getAccountName() {
		return accountName;
	}

	public double getPurchaseValue() {
		return purchaseValue;
	}

	@Override
	public String toString() {
		return "CreditCheckRequest [accountName=" + accountName + ", purchaseValue=" + purchaseValue + "]";
	}
	
	
}
