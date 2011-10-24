package org.springframework.amqp.rabbit.stocks.service;

import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;

import org.apache.commons.httpclient.HttpClient;
import org.apache.commons.httpclient.params.HttpClientParams;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.amqp.rabbit.stocks.domain.CreditCheckRequest;
import org.springframework.amqp.rabbit.stocks.domain.CreditCheckResponse;
import org.springframework.amqp.rabbit.stocks.domain.TradeRequest;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.client.CommonsClientHttpRequestFactory;
import org.springframework.http.converter.HttpMessageConverter;
import org.springframework.http.converter.json.MappingJacksonHttpMessageConverter;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.web.client.RestTemplate;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration
public class DefaultCreditCheckServiceTests {

	@Autowired
	private CreditCheckService creditCheckService;
	
	@Test
	public void creditCheck() {
		TradeRequest tr = new TradeRequest();
		tr.setAccountName("ACCT-123");
		tr.setBuyRequest(true);
		tr.setOrderType("MARKET");
		tr.setTicker("AAPL");
		tr.setQuantity(10);
		tr.setRequestId("REQ-1");
		tr.setUserName("Joe Trader");
		tr.setUserName("Joe");
		
		List<String> errors = new ArrayList<String>();
		boolean canExecute = creditCheckService.canExecute(tr, errors);
		assertTrue(canExecute);
		
		errors.clear();
		tr.setQuantity(10000000);
		
		canExecute = creditCheckService.canExecute(tr, errors);
		assertFalse(canExecute);
	}
	
	
	
	public void test() throws ClassNotFoundException {
		RestTemplate template = restTemplate();
		
		//CreditCheckRequest request= new CreditCheckRequest("ACCT1", 100000000);
		String account = "ACCT1";
		long purchaseValue = 1000;
			
		CreditCheckResponse response = template.getForObject("http://localhost:1100/home/CreditCheck/?accountname={0}&purchasevalue={1}", CreditCheckResponse.class, account, purchaseValue);			
		System.out.println(response);
		
		//CreditCheckRequest request= new CreditCheckRequest("ACCT1", 100000000);
		//CreditCheckResponse response = template.postForObject("http://localhost:1100/home/CreditCheck", request, CreditCheckResponse.class);
		//System.out.println(response);
		
	}
	
	public CommonsClientHttpRequestFactory requestFactory() {
		HttpClientParams clientParams = new HttpClientParams();
		clientParams.setConnectionManagerClass(org.apache.commons.httpclient.MultiThreadedHttpConnectionManager.class);

		HttpClient httpClient = new HttpClient(clientParams);

		CommonsClientHttpRequestFactory requestFactory = new CommonsClientHttpRequestFactory(httpClient);
		return requestFactory;
	}
	
  public RestTemplate restTemplate() throws ClassNotFoundException {
    RestTemplate template = new RestTemplate(requestFactory());
    
  	List<HttpMessageConverter<?>> messageConverters = template.getMessageConverters();
  	List<HttpMessageConverter<?>> converters = new ArrayList<HttpMessageConverter<?>>(messageConverters);
   
  	MappingJacksonHttpMessageConverter jsonConverter = new MappingJacksonHttpMessageConverter();
  	converters.add(jsonConverter);	
  	template.setMessageConverters(converters);
  	
    return template;
  }

}
