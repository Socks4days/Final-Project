CREATE TABLE [dbo].[Stock] (
    [StockId]              INT            IDENTITY (1, 1) NOT NULL,
    [StockName]            NVARCHAR (50)  NOT NULL,
    [StockDescription]     NVARCHAR (100) NOT NULL,
    [Price]                DECIMAL (18)   NOT NULL,
    [DeliveryTimeDays]     INT            NULL,
    [MaximumLevel]         INT            NOT NULL,
    [MinimumLevel]         INT            NOT NULL,
    [OrderQuantity]        INT            NULL,
    [StockCheckFrequency]  INT            NULL,
    [StockLevel]           INT            NOT NULL,
    [LastUpdatedByStaffId] INT            NULL,
    [Active] INT NOT NULL DEFAULT 1, 
    PRIMARY KEY CLUSTERED ([StockId] ASC)
);

