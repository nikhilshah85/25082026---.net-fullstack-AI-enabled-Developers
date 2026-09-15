create view emprecords
as
select * from empInfo

select * from emprecords

create view empDevelopers
as
select * from empInfo where empDesignation = 'Developers'

create view empTopPaidEmployees
as
select * from empInfo where empSalary > 20000

create view empSummary
as
select count(empNo) as [Total Employees], 
	max(empSalary) as [Max Salary], 
	min(empSalary) as [Min Salary],
	sum(empSalary) as [Total Salary],
	avg(empSalary) as [Average Pay]
from empInfo


create view empDetails
as
select empNo, empname, empDesignation,
       deptNo, deptName, deptLocation as 'Works At'
	from empInfo e join deptInfo d
	on
	e.empDeptNo = d.deptNo

select * from empDetails