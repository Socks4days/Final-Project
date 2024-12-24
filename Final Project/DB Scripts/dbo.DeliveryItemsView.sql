USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[DeliveryItemsView] Script Date: 24/12/2024 14:51:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[DeliveryItemsView]
	AS SELECT [Delivery].OrderNumber, [Delivery].[DeliveryNumber], [Delivery].[DeliveryDate], [DeliveryItem].StockId, [Stock].StockName, [DeliveryItem].QuantityDelivered, [DeliveryItem].QuantityFaulty
	FROM [DeliveryItem]
	INNER JOIN [Stock] ON [Stock].StockId = [DeliveryItem].StockId
	INNER JOIN [Delivery] ON [Delivery].[DeliveryNumber] = [DeliveryItem].[DeliveryNumber]
