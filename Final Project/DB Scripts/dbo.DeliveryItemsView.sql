-- Get list of stock items delivered for an order along with counts of the number delivered and number faulty
-- Used by OrderItemsDeliveredView
CREATE VIEW [dbo].[DeliveryItemsView]
	AS SELECT
		[Delivery].OrderNumber,
		[Delivery].[DeliveryNumber],
		[Delivery].[DeliveryDate],
		[DeliveryItem].StockId,
		[Stock].StockName,
		[DeliveryItem].QuantityDelivered,
		[DeliveryItem].QuantityFaulty
	FROM [DeliveryItem]
	INNER JOIN [Stock] ON [Stock].StockId = [DeliveryItem].StockId
	INNER JOIN [Delivery] ON [Delivery].[DeliveryNumber] = [DeliveryItem].[DeliveryNumber]