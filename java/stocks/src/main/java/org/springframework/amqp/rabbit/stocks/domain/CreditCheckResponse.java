package org.springframework.amqp.rabbit.stocks.domain;

public class CreditCheckResponse {

  private String account;
  private double value;
  private boolean passFail;
  private String reason;
	public String getAccount() {
		return account;
	}
	public void setAccount(String account) {
		this.account = account;
	}
	public boolean isPassFail() {
		return passFail;
	}
	public void setPassFail(boolean passFail) {
		this.passFail = passFail;
	}
	public String getReason() {
		return reason;
	}
	public void setReason(String reason) {
		this.reason = reason;
	}
	public double getValue() {
		return value;
	}
	public void setValue(double value) {
		this.value = value;
	}
	@Override
	public String toString() {
		return "CreditCheckResponse [account=" + account + ", value=" + value + ", passFail=" + passFail + ", reason="
				+ reason + "]";
	}
  
   
}
