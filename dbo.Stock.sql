CREATE TABLE [dbo].[Stock] (
    [StockId]              NVARCHAR (50)  NOT NULL,
    [StockName]            NVARCHAR (50)  NOT NULL,
    [StockDescription]     NVARCHAR (100) NOT NULL,
    [Price]                DECIMAL (18)   NOT NULL,
    [DeliveryTimeDays]     INT            NULL,
    [MaximumLevel]         INT            NOT NULL,
    [MinimumLevel]         INT            NOT NULL,
    [OrderQuantity]        INT            NULL,
    [StockCheckFrequency]  INT            NULL,
    [StockLevel]           INT            NOT NULL,
    [LastUpdatedByStaffId] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([StockId] ASC),
    CONSTRAINT [FK_Stock_ToStaff] FOREIGN KEY ([LastUpdatedByStaffId]) REFERENCES [dbo].[Staff] ([StaffId])
);

