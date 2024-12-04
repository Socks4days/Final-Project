USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddOrderItem] Script Date: 04/12/2024 19:27:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddOrderItem]
	@OrderNumber int,
	@StockId int,
	@OrderItemQuantity int
AS
	INSERT INTO OrderLine VALUES(@OrderNumber, @StockId, @OrderItemQuantity)
RETURN 0
