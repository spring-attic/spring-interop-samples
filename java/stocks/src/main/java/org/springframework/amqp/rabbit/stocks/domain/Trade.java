/*
 * Copyright 2002-2011 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package org.springframework.amqp.rabbit.stocks.domain;

public class Trade {
	
	private int id;
	private String symbol;
	private String ordertype;
	private long quantity;
	private double executionPrice;
	private boolean error; 
	private String errorMessage;

	public Trade(int tradeId, String symbol, String ordertype, long quantity, double executionPrice) {
		super();
		this.id = tradeId;
		this.symbol = symbol;
		this.ordertype = ordertype;
		this.quantity = quantity;
		this.executionPrice = executionPrice;
	}
	
	public Trade(int tradeId, String symbol, String ordertype, long quantity, double executionPrice,  boolean error, String errorMessage) {
		this(tradeId, symbol, ordertype, quantity, executionPrice);
		this.error = error;
		this.errorMessage = errorMessage;
	}
	
	
	// TODO remove zero-arg ctor and setters, did to simplify mapping
	public Trade() {		
	}



	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getSymbol() {
		return symbol;
	}

	public void setSymbol(String symbol) {
		this.symbol = symbol;
	}

	public String getOrdertype() {
		return ordertype;
	}

	public void setOrdertype(String ordertype) {
		this.ordertype = ordertype;
	}

	public long getQuantity() {
		return quantity;
	}

	public void setQuantity(long quantity) {
		this.quantity = quantity;
	}

	public double getExecutionPrice() {
		return executionPrice;
	}

	public void setExecutionPrice(double executionPrice) {
		this.executionPrice = executionPrice;
	}


	public boolean isError() {
		return error;
	}

	public void setError(boolean error) {
		this.error = error;
	}

	public String getErrorMessage() {
		return errorMessage;
	}

	public void setErrorMessage(String errorMessage) {
		this.errorMessage = errorMessage;
	}
	
	@Override
	public String toString() {
		return "Trade [id=" + id + ", symbol=" + symbol + ", ordertype=" + ordertype + ", quantity=" + quantity
				+ ", executionPrice=" + executionPrice + ", error=" + error + ", errorMessage=" + errorMessage + "]";
	}

	

}
