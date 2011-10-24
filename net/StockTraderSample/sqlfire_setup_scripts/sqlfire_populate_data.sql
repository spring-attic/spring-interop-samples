INSERT INTO sequence VALUES('tradenum', 1000);

insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (1,'MSFT', '1', 'MARKET', 1, 25.10, '0');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (2,'APPL', '1', 'MARKET', 10, 200.00, '0');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (3,'GOOG', '0', 'LIMIT', 30, 125.10, '0');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error, errormessage)
    values (4,'CSCO', '1', 'MARKET', 100, 25.10, '1', 'you are ugly');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (5,'GOOG', '0', 'LIMIT', 500, 112.22, '0');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (6,'MSFT', '1', 'MARKET', 1500, 25.10, '0');


