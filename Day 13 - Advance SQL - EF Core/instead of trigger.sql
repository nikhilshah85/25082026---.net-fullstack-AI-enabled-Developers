--before trigger
--after trigger
--instead of trigger - this is a special trigger for views, when views are based on joins


create view emp_dept_view
as
select empNo, empName, empDesignation, empSalary, empIsActive,empDept,empSSN, deptInfo.deptNo,deptInfo.deptName, deptInfo.deptLocation
from empInfo
left join deptInfo
on empInfo.empNo = deptInfo.deptNo

select * from empInfo
select * from emp_dept_view

insert into emp_dept_view (empName,empDesignation,empSalary,empIsActive,empDept,empSSN) values('Hecter','Accountant',15000,0,30,593574)
--this we can create a instead of trigger on this table

create trigger trg_instead_of_emp_dept_view
on emp_dept_view
instead of insert 
as
begin
insert into empInfo (empName,empDesignation,empSalary,empIsActive,empDept,empSSN) select  empName,empDesignation,empSalary,empIsActive,empDept,empSSN from inserted
end




