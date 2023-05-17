CREATE table EMPLOYEE
(employee_id int primary key not null,
first_name varchar(20),
last_name varchar(20),
email  varchar(20),
Phone_number numeric,
hire_date date,
job_id int,
salary money,
commission_pct money,
manager_id int,
department_id int,

foreign key (job_id) references Jobs(job_id),
foreign key (department_id) references DEPARTMENTS(department_id)
);

//*DROP TABLE  EMPLOYEE;*/

CREATE TABLE Jobs(
job_id int primary key not null,
job_title varchar(20),
min_salary money,
max_salary money);

CREATE TABLE Locations(
location_id int primary key  not null,
street_address varchar(20),
postal_code int,
city varchar(20),
state_province varchar(20),
country_id int
foreign key (country_id) references Countries(Country_id)
);
CREATE TABLE Countries(country_id int primary key not null, country_name varchar(20),region_id int);
/*drop table countries*/

CREATE TABLE DEPARTMENTS(department_id INT PRIMARY KEY NOT NULL, departement_name varchar (20),location_id int, manager_id int);

insert into Locations values(101,'tholur',680552,'thrissur','kerala',91);

SELECT first_name,salary,12*(salary+100 )as  'monthly salary plus a monthly bonus of $100, multiplied by

12' from EMPLOYEE;

alter table EMPLOYEE modify  phone_number char(7);

UPDATE EMPLOYEE 
SET Phone_number= CONCAT('2',phone_number);

DELETE FROM EMPLOYEE WHERE dept_id=9;

select dept_id from EMPLOYEE where last_name='smith';

select first_name ,hire_date, salary from EMPLOYEE order by hire_date

CREATE TABLE STUDENT_GRADES(STUDENT_ID INT,SEMESTER_END DATE, GPA INT);
SELECT STUDENT_ID,GPA FROM STUDENT_GRADES ORDER BY GPA DESC;

SELECT first_name from EMPLOYEE where department_id not in (select DEPARTMENTS.department_id)

CREATE TABLE CUSTOMERS(CUSTOMER_ID int,	CUSTOMER_NAME varchar(100), CUSTOMER_ADDRESS VARCHAR(150),CUSTOMER_PHONENO VARCHAR(20));
select concat('Dear Customer',CUSTOMER_NAME,'.') FROM CUSTOMERS;

CREATE TABLE Emp(id int, name varchar(20), sal money,comm_pct money,pf money);
insert into Emp(id,name,sal,comm_pct,pf)

 values

 (1,'John Doe',50000,0.05,5000),

 (2,'Jane Smith',60000,0.1,6000),

 (3,'Bob',75000,0.15,7500);

 update Emp set

 hra=0.12*sal,

 tearn=sal+hra,

 tded=0.04*sal,

 net=tearn-tded;