USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddOrderItem] Script Date: 27/01/2025 21:05:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddOrderItem]
	@OrderNumber int,
	@StockId int,
	@OrderItemQuantity int
AS
	INSERT INTO OrderItem VALUES(@OrderNumber, @StockId, @OrderItemQuantity)
RETURN 0
