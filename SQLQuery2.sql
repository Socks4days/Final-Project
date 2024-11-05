CREATE TABLE [dbo].[Staff]
(
	[StaffId] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Forename] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [StaffPosition] NVARCHAR(50) NOT NULL, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Active] INT NULL
)