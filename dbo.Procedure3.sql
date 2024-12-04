CREATE PROCEDURE [dbo].[AddOrder]
	@OrderNumber int,
	@OrderDate DateTime,
	@OrderPlacedByStaffId int,
	@OrderStatus nvarchar(50)
AS
	INSERT INTO "Order" VALUES(@OrderNumber, @OrderDate, @OrderPlacedByStaffId, @OrderStatus)
RETURN 0
