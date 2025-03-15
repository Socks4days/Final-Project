-- Get summary of orders showing whether or not they have been fulfilled, including:
-- 1. The min/max expected delivery dates for the different items in the order
-- 2. The date of the most recent delivery received for the order
CREATE VIEW [OrdersView] AS
SELECT	[Order].OrderNumber,
		[Order].OrderDate,
		[Order].OrderPlacedByStaffId,
		CONCAT([Staff].Forename,' ',[Staff].Surname) AS OrderPlacedByStaffName,
		[Order].OrderStatus,
		MIN([OrderItemsDeliveredView].DeliveryDueDate) AS MinDeliveryDueDate,
		MAX([OrderItemsDeliveredView].DeliveryDueDate) AS MaxDeliveryDueDate,
		MAX([OrderItemsDeliveredView].DeliveryDate) AS LastDeliveryDate
FROM [Order]
-- Use left outer joins on Staff and OrderItemsDeliveredView to include orders not yet placed and orders with no items delivered
LEFT OUTER JOIN [Staff] ON [Staff].StaffId = [Order].OrderPlacedByStaffId
LEFT OUTER JOIN [OrderItemsDeliveredView] ON [OrderItemsDeliveredView].OrderNumber = [Order].OrderNumber
-- Use group by to get summary min/max values for all deliveries linked to the order
GROUP BY [Order].OrderNumber, [Order].OrderDate, [Order].OrderPlacedByStaffId,
         CONCAT([Staff].Forename,' ',[Staff].Surname), [Order].OrderStatus