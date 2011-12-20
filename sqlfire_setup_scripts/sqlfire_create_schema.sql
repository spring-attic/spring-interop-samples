DROP TABLE trade;
DROP TABLE sequence;

create table trade (
  id int not null,
  symbol varchar(20) not null,
  buyRequest varchar(2) not null,
  orderType varchar(10) not null,
  quantity int not null,
  executionprice decimal(10,2) not null,
  confirmationNumber varchar(100),
  error varchar(2) not null,
  errorMessage varchar(100), 
  constraint pk_trade primary key (id)
)
REPLICATE;

CREATE TABLE sequence
(
    name               varchar(30)  not null,
    nextid             int          not null,
    constraint pk_sequence primary key (name)
);
