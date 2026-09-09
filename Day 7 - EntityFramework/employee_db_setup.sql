create database employeeManagementNewDB;
use employeeManagementNewDB;

create table depts
		(
			deptNo int primary key,
			deptName varchar(20),
			deptLocation varchar(20)
		)

		insert into depts values(10,'HR','Texas');
		insert into depts values(20,'Accounts','New York');
		insert into depts values(30,'Training','San Francisco');
		insert into depts values(40,'IT','Vegas');
	-----------------------------------------------------------------------------------------------------
	create table employees
		(
			empNo int primary key,
			empName varchar(30),
			empDesignation varchar(20),
			empSalary int,
			empIsPermenant bit,
			empDept int,
			constraint fk_empDept foreign key (empDept) references depts		
		)
	
		insert into employees values(1,'Peter','Developer',3000,1,40);		
		insert into employees values(2,'Mary','Trainer',4000,1,30);		
		insert into employees values(3,'Raj','Accountant',5000,1,20);		
		insert into employees values(4,'Monica','Sr.Accountant',8000,1,20);		
		insert into employees values(5,'Penny','Sr.Hr',3100,0,10);		
		insert into employees values(6,'Leonard','Developer',12000,1,40);		
		insert into employees values(7,'Sheldon','Developer',13000,1,40);		
		insert into employees values(8,'Mike','Hr Manager',4000,1,10);		
		insert into employees values(9,'Tyson','Developer',8000,0,10);		
		insert into employees values(10,'Murray','Sr.Trainer',9000,1,30);		
		insert into employees values(11,'Peter','Developer',13000,0,40);		
		insert into employees values(12,'Julie','HR Associate',5000,1,10);



		select * from depts
		select * from employees