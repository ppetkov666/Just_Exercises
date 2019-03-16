CREATE OR ALTER PROC spSearchEmployeesBadDynamicSql
(@i_first_name NVARCHAR(100) = NULL,
@i_last_name NVARCHAR(100) = NULL,
@i_job_title NVARCHAR(100) = NULL,
@i_salary INT = null)
AS
BEGIN
	Declare @sql nvarchar(max);

	SET @sql = 'Select * from Employees Where 1=1'
	If @i_first_name is not null BEGIN
	SET @sql = @sql + ' AND Firstname=''' + @i_first_name + ''''
	END
	If @i_last_name is not null BEGIN
	SET @sql = @sql + ' AND Lastname=''' + @i_last_name + '''' 
	END
	If @i_job_title is not null BEGIN
	SET @sql = @sql + ' AND JobTitle=''' + @i_job_title + '''' 
	END
	If @i_salary is not null BEGIN
	SET @sql = @sql + ' AND Salary=''' + cast(@i_salary as nvarchar) + '''' 
	END
	EXECUTE sp_executesql @sql 
END
GO
execute spSearchEmployeesBadDynamicSql
-- -------
SET ANSI_NULLS on	

declare @i_first_name NVARCHAR(100) set @i_first_name = null
declare @i_last_name NVARCHAR(100) set @i_last_name = null
declare @i_job_title NVARCHAR(100) set @i_job_title = null
declare @i_salary NVARCHAR(100) set @i_salary = null

Declare @sql nvarchar(max) SET @sql = 'Select * from Employee Where 1 = 1'
	
	
	If (@i_first_name is not null )  BEGIN
	SET @sql = @sql + ' AND Firstname=''' + @i_first_name + ''''
	END
	If (@i_last_name is not  null) BEGIN
	SET @sql = @sql + ' AND Lastname=''' + @i_last_name + '''' 
	END
	If @i_job_title is not   null BEGIN
	SET @sql = @sql + ' AND JobTitle=''' + @i_job_title + '''' 
	END
	If @i_salary is not  null  BEGIN
	SET @sql = @sql + ' AND Salary=''' + cast(@i_salary as nvarchar) + '''' 
	END
	print @sql