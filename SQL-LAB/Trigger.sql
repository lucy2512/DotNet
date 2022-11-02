-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[limit] ON dbo.employee
   INSTEAD OF INSERT
AS 
BEGIN
	declare @sal int;
	declare @Dept varchar(10);
	declare @Max int;
	declare @Min int;

	select @sal= salary,@Dept=dept from inserted
	select @Max=max_val,@Min=min_val from dbo.salary where dept=@Dept;

	if @sal<@Min
	begin
	insert into dbo.employee select * from inserted;
	end
	else
	begin
	raiserror('Salary is not correct',16,1)
	return
	end

	

END
GO

