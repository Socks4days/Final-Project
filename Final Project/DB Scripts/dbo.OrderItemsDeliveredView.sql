USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[OrderItemsDeliveredView] Script Date: 24/12/2024 14:51:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[OrderItemsDeliveredView]
	AS 	SELECT [OrderItem].OrderNumber, [OrderItem].StockId, [Stock].StockName, [OrderItem].OrderItemQuantity, MAX([DeliveryItemsView].[DeliveryDate]) AS DeliveryDate, SUM([DeliveryItemsView].QuantityDelivered) AS QuantityDelivered, SUM([DeliveryItemsView].QuantityFaulty) AS QuantityFaulty
	FROM [OrderItem]
	INNER JOIN [Stock] ON [Stock].StockId = [OrderItem].StockId
	LEFT OUTER JOIN [DeliveryItemsView] ON [DeliveryItemsView].OrderNumber = [OrderItem].OrderNumber AND [DeliveryItemsView].StockId = [OrderItem].StockId
	GROUP BY [OrderItem].OrderNumber, [OrderItem].StockId, [Stock].StockName, [OrderItem].OrderItemQuantity
