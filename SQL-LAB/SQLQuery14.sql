USE [master]
GO
/****** Object:  Trigger [dbo].[limit]    Script Date: 02-11-2022 17:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER TRIGGER [dbo].[limit] ON [dbo].[employee]
   INSTEAD OF INSERT
AS 
BEGIN
	declare @sal int;
	declare @Dept varchar(10);
	declare @Max int;
	declare @Min int;

	select @sal= salary,@Dept=dept from inserted
	select @Max=max_val,@Min=min_val from dbo.emp_salary where dept=@Dept;

	if @sal<@Min
	begin
	raiserror('Salary is not correct',16,1)
	end
	else if  @sal>@Max
	begin
	raiserror('Salary is not correct',16,1)
	end
	else
	begin
	insert into dbo.employee select * from inserted;
	return
	end

	

END
