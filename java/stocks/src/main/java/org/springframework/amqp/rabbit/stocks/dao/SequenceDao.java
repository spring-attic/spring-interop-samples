package org.springframework.amqp.rabbit.stocks.dao;

public interface SequenceDao {
		int getNextId(final String name);
}
