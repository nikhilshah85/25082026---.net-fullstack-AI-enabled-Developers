select * from empInfo

--with select  we can also use case (switch case)
--we want to increase salary of employee
	--500 for dept 10
	--1000 for dept 20
	--1500 for dept 30
	--2000 for dept 40
	--250 for others

create view SalaryUpgrade
as
select empNo, empName, empSalary as [Old Pay], empDept, case  empDept
													when 10 then empSalary + 500 
													when 20 then empSalary + 1000
													when 30 then empSalary + 1500
													when 40 then empSalary + 2000
													else empSalary + 250
													end as [New Salary]
													from empInfo

		select * from SalaryUpgrade

		--1. it helps to hide the name of the table and columns
		--2. it helps to hide the logic, algo in the query
		--3. makes a real big large query to small 
		--DML operaions (insert, update and delete)
		--you can fire insert, update or delete on a view which is based on a single table, not joins
		--it will change the data in actual table
		--if you want to enable DML on view which are based on a join, u will have to create a trigger

		update SalaryUpgrade set empName = 'Janet Jackson' where empNo = 19

		select * from empInfo















