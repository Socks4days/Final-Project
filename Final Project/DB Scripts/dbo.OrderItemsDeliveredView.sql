-- Get list of stock items for an order, including:
-- 1. the number order ordered
-- 2. the date of the most recent delivery
-- 3. the total number that have been delivered so far for this order
-- 4. the total number received that were faulty
-- Used for the delivery discrepancy report
CREATE VIEW [dbo].[OrderItemsDeliveredView]
	AS 	SELECT
		[OrderItem].OrderNumber,
		[OrderItem].StockId,
		[Stock].StockName,
		[OrderItem].OrderItemQuantity,
		DATEADD(DAY, [Stock].DeliveryTimeDays,
		[Order].OrderDate) AS DeliveryDueDate,
		MAX([DeliveryItemsView].[DeliveryDate]) AS DeliveryDate,
		SUM([DeliveryItemsView].QuantityDelivered) AS QuantityDelivered,
		SUM([DeliveryItemsView].QuantityFaulty) AS QuantityFaulty
	FROM [OrderItem]
	-- Use inner joins for Order/Stock as these will always exist
	INNER JOIN [Order] ON [Order].OrderNumber = [OrderItem].OrderNumber
	INNER JOIN [Stock] ON [Stock].StockId = [OrderItem].StockId
	-- Use left outer join for DeliveryItemsView to include stock items that haven't been delivered yet
	LEFT OUTER JOIN [DeliveryItemsView] ON [DeliveryItemsView].OrderNumber = [OrderItem].OrderNumber AND [DeliveryItemsView].StockId = [OrderItem].StockId
	GROUP BY [OrderItem].OrderNumber, [OrderItem].StockId, [Stock].StockName, [Stock].DeliveryTimeDays, [Order].OrderDate, [OrderItem].OrderItemQuantity