USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddDeliveryItem] Script Date: 27/01/2025 21:05:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddDeliveryItem]
	@DeliveryNumber int,
	@StockId int,
	@QuantityDelivered int,
	@QuantityFaulty int
AS
	INSERT INTO DeliveryItem VALUES(@DeliveryNumber, @StockId, @QuantityDelivered, @QuantityFaulty)
RETURN 0
