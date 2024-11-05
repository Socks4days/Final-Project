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
	INSERT INTO Stock VALUES(@StockName, @StockDescription, @Price, @DeliveryTimeDays, @MaximumLevel, @MinimumLevel, @OrderQuantity, @StockCheckFrequency, @StockLevel, @LastUpdatedByStaffId)
RETURN 0
