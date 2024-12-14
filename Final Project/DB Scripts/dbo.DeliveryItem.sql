USE [C:\USERS\ANDRE\ONEDRIVE\DESKTOP\A2 SSD\TASKS\FINAL PROJECT\FINAL PROJECT\FINAL PROJECT\STOCKMANAGEMENT.MDF]
GO

/****** Object: Table [dbo].[DeliveryItem] Script Date: 14/12/2024 12:03:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DeliveryItem] (
    [DeliveryNumber]    INT NOT NULL,
    [StockId]           INT NOT NULL,
    [QuantityDelivered] INT NOT NULL,
    [QuantityFaulty]    INT NOT NULL
);


