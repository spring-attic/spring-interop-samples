INSERT INTO sequence VALUES('tradenum', 1000);

insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (1,'MSFT', 'T', 'MARKET', 1, 25.10, 'F');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (2,'APPL', 'T', 'MARKET', 10, 200.00, 'F');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (3,'GOOG', 'F', 'LIMIT', 30, 125.10, 'F');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error, errormessage)
    values (4,'CSCO', 'T', 'MARKET', 100, 25.10, 'T', 'you are ugly');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (5,'GOOG', 'F', 'LIMIT', 500, 112.22, 'F');
insert into trade (id, symbol, buyrequest, ordertype, quantity, executionprice, error)
    values (6,'MSFT', 'T', 'MARKET', 1500, 25.10, 'F');


