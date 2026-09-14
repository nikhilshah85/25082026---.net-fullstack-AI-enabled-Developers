create database employeeDBTraining
use employeeDBTraining

		create table deptInfo
		(
				deptNo int identity(10,10),
				deptName varchar(20) not null, --this should be minimum 2 characters, and should be unique
				deptLocation varchar(20) not null,  -- this could only be New York, Chicago, Texas

				constraint pk_deptno primary key(deptNo),
				constraint chk_deptName_length check (len(deptName) >= 2),
				constraint unk_deptName unique(deptName),
				constraint chk_deptLocation_values check (deptLocation in ('New York','Chicago','Texas'))
		)

		insert into deptInfo values('HR','Texas');
		insert into deptInfo values('Accounts','New York');
		insert into deptInfo values('IT','Chicago');
		insert into deptInfo values('Training','New York')
		insert into deptInfo values('Sales','Texas')
		select * from deptInfo
		--sequence is the solution to this behaviour - sequence is another object, since sql server 2014
		--sequence object can also be shared by multiple tables


create table empInfo
(
empNo int identity(1,1),
empName varchar(20) not null,
empDesignation varchar(20) not null,
empSalary int not null,
empIsActive bit not null,
empDept int not null,
empSSN varchar(9) not null,

constraint pk_empno primary key(empNo),
constraint chk_empName_length check(len(empName) >=3),
constraint chk_empDesignation_value check(empDesignation in ('HR', 'Developer', 'Accountant', 'Trainer')),
constraint chk_empSalary_value check(empSalary <= 25000 and empSalary >=  8000),
constraint fk_empDept foreign key(empDept)
references deptInfo(deptNo)
);



				

				insert into empInfo(empName, empDesignation, empSalary, empIsActive, empDept, empSSN) values
('Chris', 'Developer', 20000, 1, 30, '123456789'),
('John', 'Trainer', 25000, 1, 40, '234567891'),
('Travis', 'Developer', 22000, 0, 30, '345678912'),
('Jenny', 'Accountant', 10000, 0, 20, '456789123'),
('Stacy', 'Developer', 9000, 1, 30, '567891234'),
('Janet', 'HR', 11000, 0, 40, '678912345'),
('Harvey', 'Trainer', 13000, 1, 40, '789123456'),
('Dave', 'Developer', 19000, 1, 30, '891234567'),
('Harry', 'HR', 15000, 0, 40, '912345678'),
('Henry', 'Developer', 20000, 1, 30, '987654321'),
('John', 'Trainer', 25000, 1, 40, '876543219'),
('Stuart', 'Accountant', 22000, 0, 20, '765432198'),
('Vanessa', 'Developer', 10000, 0, 30, '654321987'),
('Julie', 'Developer', 9000, 1, 30, '543219876'),
('Jane', 'HR', 11000, 0, 20, '432198765'),
('Clancy', 'Accountant', 13000, 1, 20, '321987654'),
('Tom', 'Developer', 19000, 1, 30, '321987654'),
('Bill', 'Trainer', 15000, 0, 40, '219876543'),
('Michael', 'HR', 15000, 0, 30, '198765432'),
('Lewis', 'HR', 15000, 0, 30, '012345678');

-----------------
select * from empInfo

select * from empInfo
select empNo, empName from empInfo -- limited columns
select empNo as [Employee Number], empName as Name from empInfo -- with alias


select empNo as [Employee Number], empName as Name from empInfo order by Name -- order by - sorting
select empNo as [Employee Number], empName as Name from empInfo order by Name desc -- order by descending sort


select empNo as [Employee Number], empName as Name from empInfo where empNo > 25  order by Name desc -- greater than 25

select empNo as [Employee Number], empName as Name from empInfo where empSalary > 20000 order by Name desc --where 


select empNo as [Employee Number], empName as Name from empInfo where empSalary >15000 and empIsActive = 1  order by Name desc

select count(empNo) as [Total Employees] from empInfo

select sum(empSalary) as [Total Employees] from empInfo 

select sum(empSalary) as [Total Employees] from empInfo where empDept = 20
select sum(empSalary) as [Total Employees] from empInfo where empIsActive = 0

select avg(empSalary) as [Total Employees] from empInfo
select min(empSalary) as [Total Employees] from empInfo
select max(empSalary) as [Total Employees] from empInfo

--if we need need the agreegation for every dept ?
--use group by clause

select empDept, sum(empSalary) as [Salary],count(empNo) as [Total Employees] from empInfo group by empDept

-------------this are wild card characters
select * from empInfo where empName like 'M%' --first character an m

select * from empInfo where empName like '%M' -- last character as m

select * from empInfo where empName like '_I%'  -- second character as i

-----select with distinct --select only unique values

select distinct empDept from empInfo  -- returns unique values from that column

--with functions

select UPPER(empName) as Names from empInfo
select lower(empName) as names from empInfo
select SUBSTRING(empname,1,3) from empInfo
select 'Hello ' + empname from empInfo
select CONCAT('Hello ',substring(empName,1,3)) from empInfo

--try
--output me the email address of every employee from deptno 20
--format of email is firstname_first2charactersofdesignation@myorganizationname.co.us
--make sure complete email address is in lowercase

select lower(CONCAT(empName,'_',SUBSTRING(empInfo.empDesignation,1,2),'@myorganizationname.co.us')) as 'Email' from empInfo
where empDept = 20

select LTRIM(empName) from empInfo
select ('      Nikhil')
select RTRIM('Nikhil         ')
select trim('         Nik       ') 
select len(empName) from empInfo

-------
select GETDATE()
select MONTH(getdate())
select YEAR(getdate())

select DATEADD(year,3,getdate())

select DATEADD(hour,6,getdate())
-------------

--DML
--insert into emp --already done

update empInfo set empSalary = empSalary + 200 where empDept = 30 --this will increase the salary by 200 for emp in dept 30
delete from empInfo where empName like 'Z%'

----------------

--how do i find name and empno of the person having highest salary ?

select empNo, empName from empinfo where empSalary = (select max(empSalary) from empInfo) -- this is called as
																							--sub query


--Joins - to get data from 2 or more tables

--types of joins
--a. cross join or cartisian product
--b. equi join or inner join
--c. left join
--d. right join
--e. full join
--f. null join
--g. self join




--cross join or cartisian product -- this will multiple/map every row from left table with every row in right table
----eg. table 1 has 5 rows
--      table 2 has 3 rows
--	  so it will be 5 * 3 = 15 rows as an output

--cartisian products are used by admins, to calculate how much of max load will be there on my server, so that they can
--plan the server capacity accordingly

select * from empInfo, deptInfo 

----------
--b. equi join, only records

select empno, empname, empsalary, deptInfo.deptName, deptInfo.deptLocation 
from empInfo join deptInfo
on empInfo.empDept = deptInfo.deptNo
where deptLocation like 'N%'
order by empSalary

select count(empNo) as [Total Emp], deptInfo.deptLocation as 'City'
from
empInfo join deptInfo
on empInfo.empDept = deptInfo.deptNo
group by deptInfo.deptLocation

select count(empno) from empInfo
select COUNT(*) from deptInfo


--lets say this is fired by accounts dept to calculate salary
select * from empInfo left join deptInfo
on empInfo.empDept = deptInfo.deptNo

--left join means, show me all the records from left table and only equal records from right table


--lets say this is fired by accounts dept to calculate salary
select * from empInfo right join deptInfo
on empInfo.empDept = deptInfo.deptNo

select * from empInfo full join deptInfo
on empInfo.empDept = deptInfo.deptNo






























































