create table empInfoNew
(
	empNo int,
	empName varchar(max),
	empDesignaion varchar(20),
	empSalary int,
	empManager int,
	empDeptNo int,

	constraint pk_empno primary key(empNo)
)

insert into empInfoNew values(101,'Peter','Sales',4000,105,10)
insert into empInfoNew values(102,'Mary','Sales',4000,103,10)
insert into empInfoNew values(103,'Sheldon','Accounts',4000,105,10)
insert into empInfoNew values(104,'Raj','Sales',4000,105,10)
insert into empInfoNew values(105,'Monica','Sales',4000,105,10)
insert into empInfoNew values(106,'Chandler','Sales',4000,110,10)
insert into empInfoNew values(107,'Joye','Sales',4000,105,10)
insert into empInfoNew values(108,'Paris','Sales',4000,103,10)
insert into empInfoNew values(109,'Angelina','HR',4000,105,10)
insert into empInfoNew values(110,'Britney','Sales',4000,105,10)
insert into empInfoNew values(111,'Mary C','Sales',4000,110,10)

select * from empInfoNew

update empInfoNew set empManager = 110 where empNo=105

select * from empInfoNew

select e.empName + ' reports to ' +  r.empName [Reports To]
from empInfoNew e join empInfoNew r
on r.empNo = e.empManager

select e.empManager, count(r.empNo) as 'Team Members' from empInfoNew e
join empInfoNew r
on 
e.empManager = r.empNo
group by e.empManager

