package org.springframework.amqp.rabbit.stocks.config.server;

import java.util.ArrayList;
import java.util.List;

import org.apache.commons.httpclient.HttpClient;
import org.apache.commons.httpclient.params.HttpClientParams;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.http.client.CommonsClientHttpRequestFactory;
import org.springframework.http.converter.HttpMessageConverter;
import org.springframework.http.converter.json.MappingJacksonHttpMessageConverter;
import org.springframework.web.client.RestTemplate;

@Configuration
public class RestTemplateConfig {

	@Bean
	public CommonsClientHttpRequestFactory requestFactory() {
		HttpClientParams clientParams = new HttpClientParams();
		clientParams.setConnectionManagerClass(org.apache.commons.httpclient.MultiThreadedHttpConnectionManager.class);

		HttpClient httpClient = new HttpClient(clientParams);

		CommonsClientHttpRequestFactory requestFactory = new CommonsClientHttpRequestFactory(httpClient);
		return requestFactory;
	}
	
	@Bean
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
