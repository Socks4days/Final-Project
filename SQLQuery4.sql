USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[AddStock]
		@StockName = N'test',
		@StockDescription = N'test',
		@Price = 12,
		@DeliveryTimeDays = NULL,
		@MaximumLevel = 5,
		@MinimumLevel = 1,
		@OrderQuantity = NULL,
		@StockCheckFrequency = NULL,
		@StockLevel = 0,
		@LastUpdatedByStaffId = NULL

SELECT	@return_value as 'Return Value'

GO
