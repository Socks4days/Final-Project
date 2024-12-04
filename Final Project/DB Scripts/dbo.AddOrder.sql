USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddOrder] Script Date: 04/12/2024 19:26:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddOrder]
	@OrderNumber int OUTPUT,
	@OrderDate DateTime,
	@OrderPlacedByStaffId int,
	@OrderStatus nvarchar(50)
AS
	INSERT INTO "Order" VALUES(@OrderDate, @OrderPlacedByStaffId, @OrderStatus)
	SELECT @OrderNumber = SCOPE_IDENTITY()
RETURN 0
