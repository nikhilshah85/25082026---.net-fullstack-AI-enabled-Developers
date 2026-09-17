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







