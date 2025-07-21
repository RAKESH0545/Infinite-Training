use Assignments

--1.	Write a T-SQL Program to find the factorial of a given number.

declare @num int = 5;
declare @factorial bigint = 1;

while @num > 1
begin
    set @factorial = @factorial * @num;
    set @num = @num - 1;
end

print 'factorial is: ' + cast(@factorial as varchar);

--2.	Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 

create procedure generate_multiplication_table
    @number int,
    @upto int
as
begin
    declare @i int = 1;
    while @i <= @upto
    begin
        print cast(@number as varchar) + ' x ' + cast(@i as varchar) + ' = ' + cast(@number * @i as varchar);
        set @i = @i + 1;
    end
end

exec generate_multiplication_table @number = 5, @upto = 10;


--3. Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly

--student table

--Sid       Sname   
--1         Jack
--2         Rithvik
--3         Jaspreeth
--4         Praveen
--5         Bisa
--6         Suraj
--
--Marks table
--
--Mid      Sid     Score
--1        1        23
--2        6        95
--3        4        98
--4        2        17
--5        3        53
--6        5        13


create table student (
    sid int,
    sname varchar(50)
);

insert into student values
(1, 'jack'),
(2, 'rithvik'),
(3, 'jaspreeth'),
(4, 'praveen'),
(5, 'bisa'),
(6, 'suraj');

create table marks (
    mid int,
    sid int,
    score int
);

insert into marks values
(1, 1, 23),
(2, 6, 95),
(3, 4, 98),
(4, 2, 17),
(5, 3, 53),
(6, 5, 13);

--Query3
create function fn_getStatus(@score int)
returns varchar(4)
as
begin
    if (@score >= 50) 
		return 'Pass'
	return 'Fail'
end

select s.sid, s.sname, m.score, dbo.fn_getStatus(m.score) as status 
from student s join marks m on s.sid = m.sid
order by s.sid;




