-- View to get a count of stock items that have been ordered but not delivered yet
CREATE VIEW [dbo].[StockOnOrderView] AS
   SELECT OrderItem.StockId,
		  SUM(OrderItem.OrderItemQuantity) AS NumberOnOrder
   FROM OrderItem
   INNER JOIN [Order] ON [Order].OrderNumber = OrderItem.OrderNumber
   WHERE [Order].OrderStatus = 'Placed'
   GROUP BY OrderItem.StockId