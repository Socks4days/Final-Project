USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[StockOnOrderView] Script Date: 08/02/2025 15:05:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[StockOnOrderView] AS
   SELECT OrderItem.StockId, SUM(OrderItem.OrderItemQuantity) AS NumberOnOrder
   FROM OrderItem
   INNER JOIN [Order] ON [Order].OrderNumber = OrderItem.OrderNumber
   WHERE [Order].OrderStatus = 'Placed'
   GROUP BY OrderItem.StockId
