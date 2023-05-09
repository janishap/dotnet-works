create table client_master(CLIENTNO varchar(6)check(CLIENTNO like 'C%') primary key,NAME varchar(20) NOT NULL,
ADDRESS1 varchar(30),ADDRESS2 varchar(30),CITY varchar(15),PINCODE numeric (8),STATE varchar(15),
BALDUE numeric(10,2))


insert into client_master(CLIENTNO, NAME, CITY, PINCODE, STATE, BALDUE) 
VALUES ('C0001', 'Ivan Bayross', 'Mumbai', 400054, 'Maharashtra', 25000);

insert into client_master(CLIENTNO, NAME, CITY, PINCODE, STATE, BALDUE) 
VALUES('C0002','JANISHA','THRISSUR', 300054, 'KERALA',30000);

insert into client_master(CLIENTNO, NAME, CITY, PINCODE, STATE, BALDUE) 
VALUES('C0005','JISHNU','KUNNAMKULAM',4000066,'ladak',17500);


SELECT NAME from client_master;
SELECT * from client_master WHERE CITY='MUMBAI';
SELECT * FROM client_master WHERE NOT  STATE = 'Maharashtra';
SELECT *FROM client_master WHERE CLIENTNO IN('C00001' , 'C00002');
delete client_master where CLIENTNO='C0005';
select *from client_master where  CITY like '_a%';





CREATE TABLE PRODUCT_MASTER (PRODUCTNO varchar(6) check(PRODUCTNO like 'p%') primary key,DESCRIPTION varchar(15) not null,
PROFITPERC numeric (4,2) not null,UNITMEASURE varchar(10) not null,QTYONHAND numeric (8) NOT NULL ,
REORDERLVL numeric(8) NOT NULL ,
SELLPRICE numeric (8,2) NOT NULL,CONSTRAINT CHK1 CHECK (SELLPRICE<>0),

COSTPRICE numeric (8,2) NOT NULL,CONSTRAINT CHK2 CHECK (COSTPRICE<>0))





INSERT INTO PRODUCT_MASTER VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250);
INSERT INTO PRODUCT_MASTER VALUES('P00002', 'KURTHIS', 4, 'PEICE', 100,80,4150,350);
SELECT * FROM PRODUCT_MASTER;

SELECT *FROM PRODUCT_MASTER WHERE SELLPRICE BETWEEN 2000 AND 5000;
UPDATE  PRODUCT_MASTER SET SELLPRICE= 550 WHERE SELLPRICE=350;
select count(*) as Number from PRODUCT_MASTER where SELLPRICE>=1500;



create table SALESMAN_MASTER (
SALESMANNO varchar(6)check(SALESMANNO like 'S%') primary key, 
SALESMANNAME varchar(20) NOT NULL ,
ADDRESS1 varchar(30)NOT NULL,
ADDRESS2 varchar(30),
CITY varchar(20) ,
PINCODE numeric(8),
State varchar(20),
SALAMT numeric(8,2) NOt NULL,CONSTRAINT CHK CHECK (SALAMT<>0),
TGTTOGET numeric(6,2) NOT NULL,
YTDSALES numeric (6,2) NOT NULL ,
REMARKS varchar(60))


INSERT INTO SALESMAN_MASTER VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good');


create table SALES_ORDER (
ORDERNO varchar(6) primary key, check(ORDERNO like 'O%'), 
CLIENTNO varchar(6) Foreign Key References client_master ,
ORDERDATE date, 
DELYADDR varchar(25),
SALESMANNO varchar(6) Foreign Key references SALESMAN_MASTER, 
DELYTYPE char(1) Check (DELYTYPE='p'or DELYTYPE='f'),
BILLEDYN char(1) Check (BILLEDYN='y' or BILLEDYN='n'),
DELYDATE date, 
ORDERSTATUS varchar(20),
 check (ORDERSTATUS='inprocess'or RDERSTATUS
 'Fulfilled' or 'Backorder' or'Cancelled');
 


 INSERT INTO SALES_ORDER(OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus) 
 VALUES('O19001', '12-june-02', 'C00001', 'F', ' N', 'S00001', '20-july-02', 'In Process');


 CREATE TABLE SALES_ORDER_DETAILS (
ORDERNO varchar(6) foreign Key references SALES_ORDER ,
PRODUCTNO varchar(6) Foreign Key references PRODUCT_MASTER ,
QTYORDERED numeric(8) ,
QTYDISP numeric(8) ,
PRODUCTRATE numeric(10,2) 
CREATE Composite PRIMARY KEY of ORDERNO and 
PRODUCTNO );
 

 INSERT INTO SALES_ORDER_DETAILS (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525); 
