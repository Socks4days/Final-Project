USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: SqlProcedure [dbo].[AddStock] Script Date: 04/12/2024 19:27:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddStock]
	@StockName nvarchar(50),
	@StockDescription nvarchar(50),
	@Price decimal,
	@DeliveryTimeDays int,
	@MaximumLevel int,
	@MinimumLevel int,
	@OrderQuantity int,
	@StockCheckFrequency int,
	@StockLevel int,
	@LastUpdatedByStaffId int
AS
	INSERT INTO Stock VALUES(@StockName, @StockDescription, @Price, @DeliveryTimeDays, @MaximumLevel, @MinimumLevel, @OrderQuantity, @StockCheckFrequency, @StockLevel, @LastUpdatedByStaffId, 1)
RETURN 0
