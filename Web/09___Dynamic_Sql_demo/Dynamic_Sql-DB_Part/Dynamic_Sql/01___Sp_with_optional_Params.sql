
create or alter proc spSearchEmployees
(
@i_first_name nvarchar(100) = null,
@i_last_name nvarchar(100) = null,
@i_job_title nvarchar(100) = null,
@i_salary int = 0
)
as
begin
select * from Employees 
where 
(FirstName = @i_first_name or @i_first_name is null) and 
(LastName = @i_last_name or @i_last_name is null) and 
(JobTitle = @i_job_title or @i_job_title is null) and 
(Salary = @i_salary or @i_salary is null) 
end

exec spSearchEmployees

select * from Employees


go
declare @dynamic_sql nvarchar(1000);
declare @params nvarchar(1000);

Set @dynamic_sql = 'select * from Employees' + ' Where Firstname = @firstname and Lastname = @lastname'
set @params = '@firstname nvarchar(100), @lastname nvarchar(100)'

--print @dynamic_sql

execute sp_executesql @dynamic_sql,@params,@firstname = 'Guy', @lastname = 'Gilbert'
