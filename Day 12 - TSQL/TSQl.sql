alter function greetUser(@userName varchar(20))
returns varchar(35)
as
begin
		return 'Hello and Welcome to TSQL ' + @userName
end

select dbo.greetUser('Nikhil') as Greetings

--1. drop the function and change parameter and create function again
--instead just say alter and make ur changes


select dbo.greetUser(empName) from empInfo

--------------
create function calculate(@num1 int, @num2 int, @opt char)
returns int
as
begin
	declare @result int = 0;
	if (@opt = '+') 
	begin
		set @result = @num1 + @num2
	end

	else if (@opt = '-')
	begin
		set @result = @num1 - @num2
	end
	else if (@opt = '*')
	begin
		set @result = @num1 * @num2
	end
	else if (@opt = '/')
	begin
		set @result = @num1 / @num2
	end

	return @result
end


select dbo.calculate(10,5,'+') as Calculate

--a little complex function
--this is for HR - need to finalize the Annual CTC while hireing the employee, based are some conditions

--we take inputs from user, education, years of experience

	-- education
			--Elementary - 2000 per month
			--middle  -- 3000 per month
			--high school -- 4000 per month
			--Masters --6000 per month
	--years	0-3 - 500  
		 --   3-6 - 1500
			--6-10 - 2500
			--10+ - 4000  
			--per month + the education salary
	--additional benefit
			--travel allowance - 750 per month
			--food coupns - 900 per month
	--a tax of 7.5% will be deducted
	what will be the annual cost to company ?? 


	select dbo.CTC('Masters',6)-- this should return the annual salary

=============================================================================================================


	alter procedure addDept
	( 
	  @deptName varchar(20),
	  @deptLocation varchar(20)
	  )
	  AS
	  begin
		--we can format this inputs like
		declare @formatedLocation varchar(20) = upper(@deptLocation)
		insert into deptInfo values(@deptName,@formatedLocation)
	  end

	  exec addDept 'Consultancy','Texas'
	  select * from deptInfo




	  create table CredInfo
		(
			userName varchar(20),
			pwd varchar(20)

			constraint pk_uName primary key(userName),
			constraint ck_pwdLen check(len(pwd) > 5)
		)

		insert into CredInfo values('userOne','Pass@4321')
		insert into CredInfo values('secondUser','Pass@4532')
		insert into CredInfo values('user_three','Pass@6784')
		insert into CredInfo values('forth_user','Pass@2343')
		insert into CredInfo values('I_am_fifth','Pass@67565')

		create procedure credSP
		(
			@uName varchar(20),
			@pwd varchar(20),
			@newPwd varchar(20) = '',
			@action varchar(10),
			@result varchar(40) output
		)
		as
		begin
			if(@action = 'Login')
			begin
				declare  @loginresult int = (select count(*) from CredInfo where userName = @uName and pwd = @pwd)
				if (@loginresult = 1)
				begin
					set @result = 'Login Successful'
				end
				else
				begin
					set @result = 'Invalid Credentials'

				end
			end

			if(@action = 'NewUser')
			begin
				insert into credInfo values(@uName, @pwd)
				set @result = 'User Added Successfully'
			end

			if(@action = 'ChangePwd')
			begin
				update credinfo set pwd = @newPwd where userName = @uName
				set @result = 'Password Changed'
			end

			if(@action = 'DeleteAcc')
			begin
				delete from credInfo where userName = @uName
				set @result = 'Account Deleted'
			end

		end

		select * from credInfo


		declare @res varchar(20)
		exec credSP 'forth_user','','','DeleteAcc', @res output
		print @res


		select * from credInfo


















		select * from credInfo where userName = 'userOne' and pwd = 'Pass@4321'

		select count(*) from credInfo where userName = 'userOne' and pwd = 'sdfd@4321'