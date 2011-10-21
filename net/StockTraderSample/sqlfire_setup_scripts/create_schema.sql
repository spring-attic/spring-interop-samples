DROP TABLE TRADE;

CREATE TABLE TRADE
   (
      ID INTEGER NOT NULL CONSTRAINT TRADE_PK PRIMARY KEY,
      SYMBOL VARCHAR(10) NOT NULL,
      QUANTITY INTEGER NOT NULL,
      EXECUTIONPRICE DOUBLE PRECISION NOT NULL,
      TRADETYPE VARCHAR(10) NOT NULL
   ) REPLICATE PERSISTENT;
   
DROP TABLE CREDITCHECKFAILURE;

CREATE TABLE CREDITCHECKFAILURE
    (
      ID INTEGER NOT NULL CONSTRAINT CREDITCHECKFAILURE_PK PRIMARY KEY,
      SYMBOL VARCHAR(10) NOT NULL,
      QUANTITY INTEGER NOT NULL,
	  FAILURE_REASON VARCHAR(100) NOT NULL,
	  TRADETYPE VARCHAR(10) NOT NULL,
	  DATETIME DATE NOT NULL
	) REPLICATE PERSISTENT;