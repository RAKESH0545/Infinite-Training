create database InfinteDB

create database CodeChallenge4

use CodeChallenge4


create table books (
    id int primary key,
    title varchar(255),
    author varchar(255),
    isbn varchar(20) unique,
    published_date datetime
);

create table reviews (
    id int primary key,
    book_id int,
    reviewer_name varchar(255),
    content text,
    rating int,
    published_date datetime,
    foreign key (book_id) references books(id)
);

insert into books (id, title, author, isbn, published_date) values
(1, 'My First SQL book', 'Mary Parker', '8148302127', '2012-02-22 12:08:17'),
(2, 'My Second SQL book', 'John Mayer', '8570302231X', '1972-07-03 09:22:45'),
(3, 'My Third SQL book', 'Cary Flint', '523120Q67812', '2015-10-18 14:05:44');

insert into reviews (id, book_id, reviewer_name, content, rating, published_date) values
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'Another review', 5, '2017-10-22 23:47:10');

select * from books
where author like '%er';

select b.title, b.author, r.reviewer_name
from books b
join reviews r on b.id = r.book_id; // 

-- 2nd question

select reviewer_name 
from reviews 
group by reviewer_name 
having count(book_id) > 1;

--3rd question

create table customer (
    id int,
    name varchar(50),
    age int,
    address varchar(100),
    salary decimal(10,2)
);

insert into customer (id, name, age, address, salary) values
(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', 2000.00),
(4, 'chaitali', 25, 'mumbai', 6500.00),
(5, 'hardik', 27, 'bhopal', 8500.00),
(6, 'komal', 22, 'mp', 4500.00),
(7, 'muffy', 24, 'indore', 10000.00);

select name 
from customer 
where address like '%o%';


--4th question

create table customers (
    id int,
    name varchar(50),
    age int,
    address varchar(100),
    salary decimal(10,2)
);

insert into customers (id, name, age, address, salary) values
(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', 2000.00),
(4, 'chaitali', 25, 'mumbai', 6500.00),
(5, 'hardik', 27, 'bhopal', 8500.00),
(6, 'komal', 22, 'mp', 4500.00),
(7, 'muffy', 24, 'indore', 10000.00);

create table orders (
    oid int,
    date datetime,
    customer_id int,
    amount decimal(10,2)
);

insert into orders (oid, date, customer_id, amount) values 
(102, '2009-10-08', 3, 3000.00),
(100, '2009-10-08', 3, 1500.00),
(101, '2009-11-20', 2, 1560.00),
(103, '2008-05-20', 4, 2066.00);


select date, count(distinct customer_id) as total_customers 
from orders 
group by date;

--5th question

create table employee (
    id int,
    name varchar(50),
    age int,
    address varchar(100),
    salary decimal(10,2)
);

insert into employee (id, name, age, address, salary) values
(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', null),
(4, 'chaitali', 25, 'mumbai', 6500.00),
(5, 'hardik', 27, 'bhopal', 8500.00),
(6, 'komal', 22, 'mp', 4500.00),
(7, 'muffy', 24, 'indore', 10000.00);




-------------------------------------------------------------



create database Code_Challenge_4

use Code_Challenge_4

--1st question

create table books (
  id int primary key,
  title varchar(255),
  author varchar(255),
  isbn varchar(20) unique,
  published_date datetime
);

insert into books (id, title, author, isbn, published_date) values
(1, 'my first sql book', 'mary parker', '981483029127', '2012-02-22 12:08:17'),
(2, 'my second sql book', 'john mayer', '857300923713', '1972-07-03 02:22:45'),
(3, 'my third sql book', 'cary flint', '523120967812', '2015-10-18');




select * from books
where author like '%er';

--2nd question


create table reviews (
  id int primary key,
  book_id int,
  reviewer_name varchar(255),
  content text,
  rating int,
  published_date datetime,
  foreign key (book_id) references books(id)
);

insert into reviews (id, book_id, reviewer_name, content, rating, published_date) values 
(1, 1, 'john smith', 'my first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'john smith', 'my second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'alice walker', 'another review', 1, '2017-10-22 23:47:10');


select b.title as title, b.author as author, r.reviewer_name as reviewername 
from books b 
join reviews r on b.id = r.book_id;

--3rd question

select reviewer_name from reviews 
group by reviewer_name 
having count(distinct book_id) > 1;

--4th question

create table customer (
  id int primary key,
  name varchar(255),
  age int,
  address varchar(255),
  salary decimal(10,2)
);

insert into customer (id, name, age, address, salary) values
(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', 2000.00),
(4, 'chaitali', 25, 'mumbai', 6500.00),
(5, 'hardik', 27, 'bhopal', 8500.00),
(6, 'komal', 22, 'mp', 4500.00),
(7, 'muffy', 24, 'indore', 10000.00);


select name from customer 
where address like '%o%';


--5th question



create table customers (
  id int primary key,
  name varchar(255),
  age int,
  address varchar(255),
  salary decimal(10,2)
);

create table orders (
  oid int primary key,
  date datetime,
  customer_id int,
  amount decimal(10,2),
  foreign key (customer_id) references customers(id)
);


insert into customers (id, name, age, address, salary) values
(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', 2000.00),
(4, 'chaitali', 25, 'mumbai', 6500.00),
(5, 'hardik', 27, 'bhopal', 8500.00),
(6, 'komal', 22, 'mp', 4500.00),
(7, 'muffy', 24, 'indore', 10000.00);


insert into orders (oid, date, customer_id, amount) values 
(102, '2009-10-08', 3, 3000),
(100, '2009-11-20', 3, 1500),
(101, '2008-05-20', 2, 1560),
(103, '2008-05-20', 4, 2060);


select date, count(distinct customer_id) as total_customers 
from orders 
group by date;


--6th question


create table employee (
  id int primary key,
  name varchar(255),
  age int,
  address varchar(255),
  salary decimal(10,2)
);


insert into employee (id, name, age, address, salary) values
(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', 2000.00),
(4, 'chaitali', 25, 'mumbai', 6500.00),
(5, 'hardik', 27, 'bhopal', 8500.00),
(6, 'komal', 22, 'mp', null),
(7, 'muffy', 24, 'indore', null);


select lower(name) as name from employee 
where salary is null;


--7th question 

create table studentdetails (
  registerno int primary key,
  name varchar(255),
  age int,
  qualification varchar(255),
  mobileno varchar(20),
  mail_id varchar(255),
  location varchar(255),
  gender char(1)
);



insert into studentdetails (registerno, name, age, qualification, mobileno, mail_id, location, gender) values
(2, 'sai', 22, 'b.e', '9952836777', 'sai@gmail.com', 'chennai', 'm'),
(3, 'kumar', 20, 'bsc', '7890125648', 'kumar@gmail.com', 'madurai', 'm'),
(4, 'selvi', 22, 'b.tech', '8904567342', 'selvi@gmail.com', 'selam', 'f'),
(5, 'nisha', 25, 'm.e', '7834672310', 'nisha@gmail.com', 'theni', 'f'),
(6, 'saisaran', 21, 'b.a', '7890345678', 'saran@gmail.com', 'madurai', 'f'),
(7, 'tom', 23, 'bca', '8901234675', 'tom@gmail.com', 'pune', 'm');


select gender, count(*) as total 
from studentdetails 
group by gender;
