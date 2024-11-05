CREATE TABLE [dbo].[Staff] (
[StaffId] NVARCHAR (50) NOT NULL,
[Forename] NVARCHAR (50) NOT NULL,
[Surname] NVARCHAR (50) NOT NULL,
[StaffPosition] NVARCHAR (50) NOT NULL,
[Password] NVARCHAR (50) NOT NULL,
[Active] NVARCHAR (50) NOT NULL,
PRIMARY KEY CLUSTERED ([StaffId] ASC),
);

CREATE TABLE [dbo].[Stock] (
[StockId] NVARCHAR (50) NOT NULL,
[StockName] NVARCHAR (50) NOT NULL,
[StockDescription] NVARCHAR (100) NOT NULL,
[Price] DECIMAL (18) NOT NULL,
[DeliveryTimeDays] INT NOT NULL,
[MaximumLevel] INT NOT NULL,
[MinimumLevel] INT NOT NULL,
[OrderQuantity] INT NOT NULL,
[StockCheckFrequency] INT NOT NULL,
[StockLevel] INT NOT NULL,
[LastUpdatedByStaffId] NVARCHAR (50) NOT NULL,
PRIMARY KEY CLUSTERED ([StockId] ASC),
CONSTRAINT [FK_Stock_ToStaff] FOREIGN KEY ([LastUpdatedByStaffId]) REFERENCES
[dbo].[Staff] ([StaffId]),
);



CREATE TABLE [dbo].[Audit] (
[AuditId] NVARCHAR (50) NOT NULL,
[AuditDate] DateTime NOT NULL,
[AuditedByStaffId] NVARCHAR (50) NOT NULL,
PRIMARY KEY CLUSTERED ([AuditId] ASC),
CONSTRAINT [FK_Audit_ToStaff] FOREIGN KEY ([AuditedByStaffId]) REFERENCES
[dbo].[Staff] ([StaffId]),
);

CREATE TABLE [dbo].[StockAudit] (
[AuditId] NVARCHAR (50) NOT NULL,
[StockId] NVARCHAR (50) NOT NULL,
[PredictedAmount] INT NULL,
[ActualAmount] INT NULL,
CONSTRAINT PK_StockAudit PRIMARY KEY (AuditId, StockId),
CONSTRAINT [FK_StockAudit_ToStock] FOREIGN KEY ([StockId]) REFERENCES
[dbo].[Stock] ([StockId]),
);

CREATE TABLE [dbo].[Order] (
[OrderNumber] INT NOT NULL,
[OrderDate] DateTime NOT NULL,
[OrderPlacedByStaffId] NVARCHAR (50) NOT NULL,
[OrderStatus] NVARCHAR (50) NOT NULL,
PRIMARY KEY CLUSTERED ([OrderNumber] ASC),
CONSTRAINT [FK_Order_ToStaff] FOREIGN KEY ([OrderPlacedByStaffId]) REFERENCES
[dbo].[Staff] ([StaffId]),
);

CREATE TABLE [dbo].[OrderLine] (
[OrderNumber] INT NOT NULL,
[StockId] NVARCHAR (50) NOT NULL,
[OrderItemQuantity] INT NOT NULL,
CONSTRAINT PK_OrderLine PRIMARY KEY (OrderNumber, StockId),
CONSTRAINT [FK_OrderLine_ToOrder] FOREIGN KEY ([OrderNumber]) REFERENCES
[dbo].[Order] ([OrderNumber]),
CONSTRAINT [FK_OrderLine_ToStock] FOREIGN KEY ([StockId]) REFERENCES
[dbo].[Stock] ([StockId])
);

CREATE TABLE [dbo].[Delivery] (
[DeliveryNumber] INT NOT NULL,
[OrderNumber] INT NOT NULL,
[DeliveryDate] DateTime NOT NULL,
[DeliveryItemQuantity] INT NOT NULL,
[DeliveryItemFaultQuantity] INT NOT NULL,
[DeliveryCheckedByStaffId] NVARCHAR (50) NOT NULL,
PRIMARY KEY CLUSTERED ([DeliveryNumber] ASC),
CONSTRAINT [FK_Delivery_ToOrder] FOREIGN KEY ([OrderNumber]) REFERENCES
[dbo].[Order] ([OrderNumber]),
CONSTRAINT [FK_Delivery_Staff] FOREIGN KEY ([DeliveryCheckedByStaffId]) REFERENCES
[dbo].[Staff] ([StaffId])
);
