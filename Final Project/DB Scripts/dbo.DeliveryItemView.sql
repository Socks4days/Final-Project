USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[DeliveryItemView] Script Date: 20/12/2024 17:30:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[DeliveryItemView]
	AS SELECT [OrderItem].OrderNumber, [OrderItem].StockId, [Stock].StockName, [OrderItem].OrderItemQuantity, [Delivery].[DeliveryNumber], [Delivery].[DeliveryDate], [DeliveryItem].QuantityDelivered, [DeliveryItem].QuantityFaulty
	FROM [OrderItem]
	INNER JOIN [Stock] ON  [Stock].StockId = [OrderItem].StockId
	LEFT OUTER JOIN [Delivery] ON [Delivery].OrderNumber = [OrderItem].OrderNumber
	LEFT OUTER JOIN [DeliveryItem] ON [DeliveryItem].[DeliveryNumber] = [Delivery].[DeliveryNumber] AND [DeliveryItem].StockId = [OrderItem].StockId
