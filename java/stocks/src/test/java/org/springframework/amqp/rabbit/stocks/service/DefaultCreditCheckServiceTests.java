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
import org.springframework.http.client.CommonsClientHttpRequestFactory;
import org.springframework.http.converter.HttpMessageConverter;
import org.springframework.http.converter.json.MappingJacksonHttpMessageConverter;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.web.client.RestTemplate;

//@RunWith(SpringJUnit4ClassRunner.class)
//@ContextConfiguration
public class DefaultCreditCheckServiceTests {

	@Test
	public void test() throws ClassNotFoundException {
		RestTemplate template = restTemplate();
		
		CreditCheckRequest request= new CreditCheckRequest("ACCT1", 100000000);
		CreditCheckResponse response = template.getForObject("http://localhost:1100/home/CreditCheck/?accountname=acct-123&purchasevalue=10000000", CreditCheckResponse.class);			
		System.out.println(response);
		
		response = template.postForObject("http://localhost:1100/home/CreditCheck", request, CreditCheckResponse.class);
		System.out.println(response);
		
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
