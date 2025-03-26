-- Stored Procedure for adding an order
CREATE PROCEDURE [dbo].[AddOrder]
	@OrderNumber int OUTPUT,
	@OrderDate DateTime,
	@OrderPlacedByStaffId int,
	@OrderStatus nvarchar(50)
AS
	INSERT INTO "Order" VALUES(@OrderDate, @OrderPlacedByStaffId, @OrderStatus)
	SELECT @OrderNumber = SCOPE_IDENTITY()
RETURN 0