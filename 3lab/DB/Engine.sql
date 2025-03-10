CREATE TABLE [dbo].[Engines] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [ModelEngine] NVARCHAR(10) NULL DEFAULT 'None', 
    [Cylinders] INT NULL DEFAULT 0,
    [HorsePower] INT NULL DEFAULT 0,
    [Work] BIT NULL DEFAULT 0
);