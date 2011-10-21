DROP TABLE trades;

create table trades (
  tradeid int not null,
  symbol varchar(20) not null,
  quantity int not null,
  executionprice decimal(10,2) not null,
  tradetype varchar(10) not null,
  constraint pk_trades primary key (tradeid)
)
REPLICATE;