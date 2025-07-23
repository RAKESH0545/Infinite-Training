use Assignments

--	1.	Write a query to display your birthday( day of week)

create table people (
    personid int primary key,
    name varchar(50),
    birthday date
);

insert into people (personid, name, birthday)
values 
(1, 'Rajesh', '2000-08-15'),
(2, 'Ramesh', '2001-12-01'),
(3, 'Amit', '2001-05-20'),
(4, 'Modasai', '2002-03-10'),
(5, 'Rahul', '2002-11-25'),
(6, 'Rakesh', '2003-07-04'),
(7, 'Kiran', '2001-01-01'),
(8, 'Prasad', '1999-09-30');

select * from people

--Question1
select 
    name,
    birthday,
    datename(weekday, birthday) as dayofweek
from people
where name = 'Rakesh';



--	2.	Write a query to display your age in days
--used first table for query2

select 
    name,
    birthday,
    datediff(day, birthday, getdate()) as age_in_days
from people
where name = 'Rakesh'

drop table people


--	3.	Write a query to display all employees information those who 
--	joined before 5 years in the current month
-- 
--	(Hint : If required update some HireDates in your EMP table of 
--	the assignment)
-- 

create table emp1 (
    empid int primary key,
    empname varchar(50),
    hiredate date,
    department varchar(50),
    salary decimal(10,2)
);


insert into emp1 values
(1, 'ravi kumar', '2018-07-10', 'developer', 50000),
(2, 'sita ram', '2019-06-15', 'analyst', 45000),
(3, 'arjun reddy', '2020-07-20', 'manager', 70000),
(4, 'manoj kumar', '2017-07-05', 'developer', 52000),
(5, 'rahul verma', '2021-08-01', 'tester', 40000),
(6, 'vikas mehra', '2016-07-25', 'analyst', 48000),
(7, 'sandeep joshi', '2015-07-30', 'developer', 53000),
(8, 'anil yadav', '2022-07-10', 'hr', 42000),
(9, 'deepak singh', '2014-07-15', 'manager', 75000),
(10, 'amit sharma', '2013-07-01', 'developer', 60000);

--Question3
select * from emp1
where hiredate < dateadd(year, -5, getdate())
and month(hiredate) = month(getdate());

drop table emp1

-- 
--	4.	Create table Employee with empno, ename, sal, doj columns or use your emp table and perform the following operations in a single transaction
--		a. First insert 3 rows 
--		b. Update the second row sal with 15% increment  
--		c. Delete first row.
--	After completing above all actions, recall the deleted row without losing increment of second row.
-- 

create table employee (
    empno int primary key,
    ename varchar(50),
    sal decimal(10,2),
    doj date
);

begin transaction;

-- a. insert 3 rows
insert into employee values
(1, 'ravi kumar', 30000, '2020-01-10'),
(2, 'arjun reddy', 40000, '2019-03-15'),
(3, 'manoj kumar', 35000, '2021-06-20');

-- b. update second row salary with 15% increment
update employee
set sal = sal * 1.15
where empno = 2;

-- c. delete first row
delete from employee
where empno = 1;

-- recall deleted row without losing increment of second row
rollback;

--Question4
-- check final data
select * from employee;



drop table employee




--	5.      Create a user defined function calculate Bonus for all employees of a  given dept using 	following conditions
--		a.     For Deptno 10 employees 15% of sal as bonus.
--		b.     For Deptno 20 employees  20% of sal as bonus
--		c      For Others employees 5%of sal as bonus
-- 

create table emp2 (
    empid int primary key,
    empname varchar(50),
    sal decimal(10,2),
    doj date,
    deptno int,
    deptname varchar(50)
);

insert into emp2 values
(1, 'ravi kumar', 1200, '2020-01-10', 10, 'sales'),
(2, 'arjun reddy', 1400, '2019-03-15', 20, 'marketing'),
(3, 'manoj kumar', 1600, '2021-06-20', 30, 'hr'),
(4, 'rahul verma', 1300, '2022-02-18', 10, 'sales'),
(5, 'vikas mehra', 1700, '2021-11-25', 20, 'finance'),
(6, 'sandeep joshi', 1100, '2020-08-30', 10, 'sales'),
(7, 'anil yadav', 1800, '2019-05-12', 30, 'admin'),
(8, 'deepak singh', 1250, '2018-09-03', 20, 'marketing'),
(9, 'amit sharma', 1450, '2023-04-10', 10, 'sales'),
(10, 'rohit sen', 1350, '2022-12-01', 40, 'support');


select * from emp2

create function calculateBonus (@deptno int, @sal decimal(10,2))
returns decimal(10,2)
as
begin
    declare @bonus decimal(10,2)

    if @deptno = 10
        set @bonus = @sal * 0.15
    else if @deptno = 20
        set @bonus = @sal * 0.20
    else
        set @bonus = @sal * 0.05

    return @bonus
end;

--Question5

select empid, empname, sal, deptno, deptname,
       dbo.calculateBonus(deptno, sal) as bonus
from emp2;




--	6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500 (use emp table)
--used same table as question5


create procedure updateSalesSalary
as
begin
    update emp2
    set sal = sal + 500
    where deptname = 'sales' and sal < 1500;
end;


exec updateSalesSalary;

--Question6

select * from emp2;






