package org.springframework.amqp.rabbit.stocks.generated.domain;

import static com.mysema.query.types.PathMetadataFactory.*;

import com.mysema.query.types.*;
import com.mysema.query.types.path.*;

import com.mysema.query.sql.*;
import java.util.*;


/**
 * QTrade is a Querydsl query type for QTrade
 */
@Table("TRADE")
@Schema("APP")
public class QTrade extends RelationalPathBase<QTrade> {

    private static final long serialVersionUID = 1404927941;

    public static final QTrade trade = new QTrade("TRADE");

    public final StringPath buyrequest = createString("BUYREQUEST");

    public final StringPath confirmationnumber = createString("CONFIRMATIONNUMBER");

    public final StringPath error = createString("ERROR");

    public final StringPath errormessage = createString("ERRORMESSAGE");

    public final NumberPath<java.math.BigDecimal> executionprice = createNumber("EXECUTIONPRICE", java.math.BigDecimal.class);

    public final NumberPath<Integer> id = createNumber("ID", Integer.class);

    public final StringPath ordertype = createString("ORDERTYPE");

    public final NumberPath<Integer> quantity = createNumber("QUANTITY", Integer.class);

    public final StringPath symbol = createString("SYMBOL");

    public final PrimaryKey<QTrade> tradePk = createPrimaryKey(id);

    public QTrade(String variable) {
        super(QTrade.class, forVariable(variable));
    }

    public QTrade(BeanPath<? extends QTrade> entity) {
        super(entity.getType(), entity.getMetadata());
    }

    public QTrade(PathMetadata<?> metadata) {
        super(QTrade.class, metadata);
    }

}

