USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: View [dbo].[OrdersView] Script Date: 27/01/2025 21:06:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [OrdersView] AS SELECT [Order].OrderNumber, [Order].OrderDate, [Order].OrderPlacedByStaffId,
       CONCAT([Staff].Forename,' ',[Staff].Surname) AS OrderPlacedByStaffName,
       [Order].OrderStatus,
       MIN([OrderItemsDeliveredView].DeliveryDueDate) AS MinDeliveryDueDate,
       MAX([OrderItemsDeliveredView].DeliveryDueDate) AS MaxDeliveryDueDate,
       MAX([OrderItemsDeliveredView].DeliveryDate) AS LastDeliveryDate

FROM [Order]
LEFT OUTER JOIN [Staff] ON [Staff].StaffId = [Order].OrderPlacedByStaffId
LEFT OUTER JOIN [OrderItemsDeliveredView] ON [OrderItemsDeliveredView].OrderNumber = [Order].OrderNumber
GROUP BY [Order].OrderNumber, [Order].OrderDate, [Order].OrderPlacedByStaffId,
         CONCAT([Staff].Forename,' ',[Staff].Surname), [Order].OrderStatus
