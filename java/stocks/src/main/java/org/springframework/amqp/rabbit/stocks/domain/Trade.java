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
	private int quantity;
	private double executionPrice;
	private String error = "T";  // ('T' or 'F');
	private String errorMessage;

	public Trade(int tradeId, String symbol, String ordertype, int quantity, double executionPrice) {
		super();
		this.id = tradeId;
		this.symbol = symbol;
		this.ordertype = ordertype;
		this.quantity = quantity;
		this.executionPrice = executionPrice;
	}
	
	public Trade(int tradeId, String symbol, String ordertype, int quantity, double executionPrice,  String error, String errorMessage) {
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

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public double getExecutionPrice() {
		return executionPrice;
	}

	public void setExecutionPrice(double executionPrice) {
		this.executionPrice = executionPrice;
	}

	public String getError() {
		return error;
	}

	public void setError(String error) {
		this.error = error;
	}

	public String getErrorMessage() {
		return errorMessage;
	}

	public void setErrorMessage(String errorMessage) {
		this.errorMessage = errorMessage;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((error == null) ? 0 : error.hashCode());
		result = prime * result + ((errorMessage == null) ? 0 : errorMessage.hashCode());
		long temp;
		temp = Double.doubleToLongBits(executionPrice);
		result = prime * result + (int) (temp ^ (temp >>> 32));
		result = prime * result + id;
		result = prime * result + ((ordertype == null) ? 0 : ordertype.hashCode());
		result = prime * result + quantity;
		result = prime * result + ((symbol == null) ? 0 : symbol.hashCode());
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Trade other = (Trade) obj;
		if (error == null) {
			if (other.error != null)
				return false;
		} else if (!error.equals(other.error))
			return false;
		if (errorMessage == null) {
			if (other.errorMessage != null)
				return false;
		} else if (!errorMessage.equals(other.errorMessage))
			return false;
		if (Double.doubleToLongBits(executionPrice) != Double.doubleToLongBits(other.executionPrice))
			return false;
		if (id != other.id)
			return false;
		if (ordertype == null) {
			if (other.ordertype != null)
				return false;
		} else if (!ordertype.equals(other.ordertype))
			return false;
		if (quantity != other.quantity)
			return false;
		if (symbol == null) {
			if (other.symbol != null)
				return false;
		} else if (!symbol.equals(other.symbol))
			return false;
		return true;
	}

	@Override
	public String toString() {
		return "Trade [id=" + id + ", symbol=" + symbol + ", ordertype=" + ordertype + ", quantity=" + quantity
				+ ", executionPrice=" + executionPrice + ", error=" + error + ", errorMessage=" + errorMessage + "]";
	}

	

}
