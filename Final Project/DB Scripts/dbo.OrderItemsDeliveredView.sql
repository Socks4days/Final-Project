USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[OrderItemsDeliveredView] Script Date: 27/01/2025 21:06:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[OrderItemsDeliveredView]
	AS 	SELECT [OrderItem].OrderNumber, [OrderItem].StockId, [Stock].StockName, [OrderItem].OrderItemQuantity,
			   DATEADD(DAY, [Stock].DeliveryTimeDays, [Order].OrderDate) AS DeliveryDueDate,
			   MAX([DeliveryItemsView].[DeliveryDate]) AS DeliveryDate,
			   SUM([DeliveryItemsView].QuantityDelivered) AS QuantityDelivered,
			   SUM([DeliveryItemsView].QuantityFaulty) AS QuantityFaulty
	FROM [OrderItem]
	INNER JOIN [Order] ON [Order].OrderNumber = [OrderItem].OrderNumber
	INNER JOIN [Stock] ON [Stock].StockId = [OrderItem].StockId
	LEFT OUTER JOIN [DeliveryItemsView] ON [DeliveryItemsView].OrderNumber = [OrderItem].OrderNumber AND [DeliveryItemsView].StockId = [OrderItem].StockId
	GROUP BY [OrderItem].OrderNumber, [OrderItem].StockId, [Stock].StockName, [Stock].DeliveryTimeDays, [Order].OrderDate, [OrderItem].OrderItemQuantity
