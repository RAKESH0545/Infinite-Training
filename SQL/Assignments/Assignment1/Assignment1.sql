create database Assignments

use Assignments

create table Clients 
(client_id int primary key,
cname varchar(40) not null,
address varchar(30),
email varchar(30) unique,
phone bigint,
business varchar(20) not null)

create table Departments 
(deptno int primary key,
dname varchar(15) not null,
loc varchar(20))

create table Employees 
(empno int primary key,
ename varchar(20) not null,
job varchar(15),
salary int check (salary > 0),
deptno int foreign key references Departments(deptno))

create table Projects 
(project_id int primary key,
descr varchar(30) not null,
start_date date,
planned_end_date date,
actual_end_date date,
budget int check (budget > 0),
client_id int foreign key references Clients(client_id))

alter table projects
add constraint datecheck
check (actual_end_date > planned_end_date)

create table empprojecttasks 
(project_id int foreign key references Projects(project_id),
empno int foreign key references Employees(empno),
start_date date,
end_date date,
task varchar(25) not null,
status varchar(15) not null,
primary key (project_id, empno))

insert into Clients values
(1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', 9567880032, 'Manufacturing'),
(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090, 'Consultant'),
(1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886655, 'Reseller'),
(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional')

insert into Departments values
(10, 'Design', 'Pune'),
(20, 'Development', 'Pune'),
(30, 'Testing', 'Mumbai'),
(40, 'Document', 'Mumbai')

insert into Employees values
(7001, 'Sandeep', 'Analyst', 25000, 10),
(7002, 'Rajesh', 'Designer', 30000, 10),
(7003, 'Madhav', 'Developer', 40000, 20),
(7004, 'Manoj', 'Developer', 40000, 20),
(7005, 'Abhay', 'Designer', 35000, 10),
(7006, 'Uma', 'Tester', 30000, 30),
(7007, 'Gita', 'Tech. Writer', 30000, 40),
(7008, 'Priya', 'Tester', 35000, 30),
(7009, 'Nutan', 'Developer', 45000, 20),
(7010, 'Smita', 'Analyst', 20000, 10),
(7011, 'Anand', 'Project Mgr', 65000, 10)

insert into projects values
(401, 'Inventory', '2011-04-01', '2011-10-01', '2011-10-31', 150000, 1001),
(402, 'Accounting', '2011-08-01', '2012-01-01', null, 500000, 1002),
(403, 'Payroll', '2011-10-01', '2011-12-31', null, 75000, 1003),
(404, 'Contact Mgmt', '2011-11-01', '2011-12-31', null, 50000, 1004)

insert into empprojecttasks values
(401, 7001, '2011-04-01', '2011-04-20', 'System Analysis', 'Completed'),
(401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed'),
(401, 7003, '2011-06-01', '2011-07-15', 'Coding', 'Completed'),
(401, 7004, '2011-07-18', '2011-07-31', 'Coding', 'Completed'),
(401, 7006, '2011-09-03', '2011-09-15', 'Testing', 'Completed'),
(401, 7009, '2011-09-18', '2011-10-05', 'Code Change', 'Completed'),
(401, 7008, '2011-10-06', '2011-10-16', 'Testing', 'Completed'),
(401, 7007, '2011-10-06', '2011-10-22', 'Documentation', 'Completed'),
(401, 7011, '2011-10-22', '2011-10-31', 'Sign Off', 'Completed'),
(402, 7010, '2011-08-01', '2011-08-20', 'System Analysis', 'Completed'),
(402, 7002, '2011-08-22', '2011-09-30', 'System Design', 'Completed'),
(402, 7004, '2011-10-11', null, 'Coding', 'In Progress')

select * from Clients

select * from Employees

select * from Departments

select * from Projects

select * from empprojecttasks

drop table projects

drop table departments

drop table employees

drop table empprojecttasks 

drop table clients





