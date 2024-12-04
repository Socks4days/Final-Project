USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: Table [dbo].[Delivery] Script Date: 04/12/2024 19:23:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Delivery] (
    [DeliveryNumber]            INT      IDENTITY (1, 1) NOT NULL,
    [OrderNumber]               INT      NOT NULL,
    [DeliveryDate]              DATETIME NOT NULL,
    [DeliveryItemQuantity]      INT      NOT NULL,
    [DeliveryItemFaultQuantity] INT      NOT NULL,
    [DeliveryCheckedByStaffId]  INT      NOT NULL
);


