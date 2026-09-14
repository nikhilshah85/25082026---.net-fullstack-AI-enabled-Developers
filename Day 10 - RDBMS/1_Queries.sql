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