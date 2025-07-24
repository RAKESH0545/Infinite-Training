use Assignments

-- 1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

--  a) HRA as 10% of Salary
--  b) DA as 20% of Salary
--  c) PF as 8% of Salary
--  d) IT as 5% of Salary
--  e) Deductions as sum of PF and IT
--  f) Gross Salary as sum of Salary, HRA, DA
--  g) Net Salary as Gross Salary - Deductions
--
--	Print the payslip neatly with all details

create procedure GeneratePaySlip @employeeID int
as 
begin

declare @Name varchar(50)
declare @Salary float
declare @HRA float
declare @DA float
declare @PF float
declare @IT float
declare @Deductions float
declare @GrossSalary float
declare @NetSalary float

select @Name = ename , @Salary = Salary
from Employees
where empno = @EmployeeID

set @HRA = @Salary*0.10
set @DA = @Salary*0.20
set @PF = @Salary*0.08
set @IT = @Salary*0.05
set @Deductions = @PF + @IT
set @GrossSalary = @Salary + @HRA + @DA
set @NetSalary = @GrossSalary - @Deductions

print 'Payslip for EmployeeID: ' + cast(@EmployeeID as varchar(50))
print 'Name: '+ @Name
print 'Salary: ' + cast(@Salary as varchar(50))
print 'HRA: '+ cast(@HRA as varchar(50))
print 'DA: ' + cast(@DA as varchar(50))
print 'PF: ' + cast(@PF as varchar(50))
print 'IT: ' + cast(@IT as varchar(50))
print 'Gross Salary: ' +CAST(@GrossSalary as varchar(50))
print 'Deductions: '+CAST(@Deductions as varchar(50))
print 'Net Salary: ' +CAST(@NetSalary as varchar(50))
end
--Question1
exec GeneratePaySlip @EmployeeID = 7012

select * from Employees










--
--	2.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manipulate" etc
--
--	Note: Create holiday table with (holiday_date,Holiday_name). Store at least 4 holiday details. try to match and stop manipulation 



create table Holidays
(holiday_date date primary key,
holiday_name varchar(50))

insert into holidays values
('2025-01-01', 'New Year'),
('2025-01-26', 'Republic Day'),
('2025-05-01', 'May Day'),
('2025-08-15', 'Independence Day'),
('2025-12-25', 'Christmas')

drop trigger RestrictManipOnHolidays

create or alter trigger RestrictManipOnHolidays
on employees
for insert, update, delete
as
begin
    declare @holidayname varchar(50);

    select @holidayname = holiday_name
    from holidays
    where holiday_date = cast(getdate() as date);

    if @holidayname is not null
    begin
        raiserror('Due to %s, you cannot manipulate data today!', 16, 1, @holidayname);
        rollback transaction;
    end
end;

insert into Employees values
(7014, 'Naresh', 'Developer' , 40000,20)



select * from Employees

























