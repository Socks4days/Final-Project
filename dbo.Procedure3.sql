CREATE PROCEDURE [dbo].[AddOrder]
	@OrderDate DateTime = NULL,
	@OrderPlacedByStaffId int,
	@OrderStatus nvarchar(50)
AS
	INSERT INTO "Order" VALUES(@OrderDate, @OrderPlacedByStaffId, @OrderStatus)
RETURN 0
