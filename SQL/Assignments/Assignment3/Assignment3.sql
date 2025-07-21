use Assignments


create table dept (
    deptno int primary key,
    dname varchar(50),
    loc varchar(50)
);

create table emp (
    empno int primary key,
    ename varchar(50),
    job varchar(50),
    mgr_id int,
    hiredate date,
    sal numeric(10, 2),
    comm numeric(10, 2),
    deptno int,
    foreign key (deptno) references dept(deptno)
);

insert into dept (deptno, dname, loc) values
(10, 'accounting', 'new york'),
(20, 'research', 'dallas'),
(30, 'sales', 'chicago'),
(40, 'operations', 'boston');


insert into emp (empno, ename, job, mgr_id, hiredate, sal, comm, deptno) values
(7369, 'smith', 'clerk', 7902, '1980-12-17', 800, null, 20),
(7499, 'allen', 'salesman', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'ward', 'salesman', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'jones', 'manager', 7839, '1981-04-02', 2975, null, 20),
(7654, 'martin', 'salesman', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'blake', 'manager', 7839, '1981-05-01', 2850, null, 30),
(7782, 'clark', 'manager', 7839, '1981-06-09', 2450, null, 10),
(7788, 'scott', 'analyst', 7566, '1987-04-19', 3000, null, 20),
(7839, 'king', 'president', null, '1981-11-17', 5000, null, 10),
(7844, 'turner', 'salesman', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'adams', 'clerk', 7788, '1987-05-23', 1100, null, 20),
(7900, 'james', 'clerk', 7698, '1981-12-03', 950, null, 30),
(7902, 'ford', 'analyst', 7566, '1981-12-03', 3000, null, 20),
(7934, 'miller', 'clerk', 7782, '1982-01-23', 1300, null, 10);



select * from dept

select * from emp


--1. Retrieve a list of MANAGERS. 
--Query1
select * from emp where empno in (select mgr_id from emp)
 
--2. Find out the names and salaries of all employees earning more than 1000 per month. 
--Query2
select ename, Sal from emp where sal > 1000
 
--3. Display the names and salaries of all employees except JAMES. 
--Query3
select ename, Sal from emp where ename <> 'James'
 
--4. Find out the details of employees whose names begin with ‘S’. 
--Query4
select * from emp where ename like 'S%'
 
--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
--Query5
select ename from emp where ename like '%A%'
 
--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
--Query6
select ename from emp where ename like '__L%'
 
--7. Compute daily salary of JONES.
--Query7
select ename , (sal/30)  from emp where ename = 'JONES'
 
--8. Calculate the total monthly salary of all employees. 
--Query8
select sum(sal)  from emp
 
--9. Print the average annual salary . 
--Query9
select avg(sal)*12  from emp
 
--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
--Query10
select ename , Job, deptno from emp 
where ename not in (select ename from emp where deptno = 30 and job = 'salesman')
 
--11. List unique departments of the EMP table. 
--Query11
select distinct(deptno) from emp
 
--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
--Query12
select ename , sal  from emp where sal > 1500 and deptno in (10, 30)
 
--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST 
--and their salary is not equal to 1000, 3000, or 5000. 
--Query13
select ename , Job, Sal from emp where job in ('MANAGER', 'ANALYST') and sal not in (100, 3000, 5000)
 
--14. Display the name, salary and commission for all employees whose commission amount is greater 
--than their salary increased by 10%. 
--Query14
select ename , Sal, comm  from emp where comm > (sal *1.1)
 
--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
--Query15
select ename  from emp where ename like '%L%L%' and (deptno = 30 or mgr_id =7782)
 
--16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees. 
--Query16
select ename  from emp where datediff(year,hiredate,getdate()) between 31 and 39
select count(*)  from emp where datediff(year,hiredate,getdate()) between 31 and 39
 
--17. Retrieve the names of departments in ascending order and their employees in descending order. 
--Query17
select dname , ename  from dept join emp
on dept.deptno = emp.deptno 
order by dname, ename desc
 
--18. Find out experience of MILLER. 
--Query18
select ename , datediff(year, hiredate, getdate())  from emp where ename = 'MILLER'



drop table emp 
drop table dept


















