package org.springframework.amqp.rabbit.stocks.config;

import org.codehaus.jackson.map.MapperConfig;
import org.codehaus.jackson.map.PropertyNamingStrategy;
import org.codehaus.jackson.map.introspect.AnnotatedField;
import org.codehaus.jackson.map.introspect.AnnotatedMethod;

public class UpperCaseNamingStrategy extends PropertyNamingStrategy {
	@Override
	public String nameForGetterMethod(MapperConfig<?> config, AnnotatedMethod method, String defaultName) {
		return translate(defaultName);
	}

	@Override
	public String nameForSetterMethod(MapperConfig<?> config, AnnotatedMethod method, String defaultName) {
		return translate(defaultName);
	}

	@Override
	public String nameForField(MapperConfig<?> config, AnnotatedField field, String defaultName) {
		return translate(defaultName);
	}

	private String translate(String defaultName) {
		char[] nameChars = defaultName.toCharArray();
		if(Character.isUpperCase(nameChars[0])) {
			nameChars[0] = Character.toLowerCase(nameChars[0]);
		}
		return String.valueOf(nameChars);
	}
}
