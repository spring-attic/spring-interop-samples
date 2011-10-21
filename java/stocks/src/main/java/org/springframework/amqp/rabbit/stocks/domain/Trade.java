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
	
	private String tradeId;
	private String symbol;
	private String ordertype;
	private long quantity;
	private double executionPrice;
	
	public Trade(String symbol, String ordertype, long quantity, double executionPrice) {
		super();
		this.symbol = symbol;
		this.ordertype = ordertype;
		this.quantity = quantity;
		this.executionPrice = executionPrice;
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

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		long temp;
		temp = Double.doubleToLongBits(executionPrice);
		result = prime * result + (int) (temp ^ (temp >>> 32));
		result = prime * result + ((ordertype == null) ? 0 : ordertype.hashCode());
		result = prime * result + (int) (quantity ^ (quantity >>> 32));
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
		if (Double.doubleToLongBits(executionPrice) != Double.doubleToLongBits(other.executionPrice))
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
	
	
	
	

}
