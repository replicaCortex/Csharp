CREATE TABLE [dbo].[Machines]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Metal] NVARCHAR(10) NULL DEFAULT 'None',   
    [Age] INT NULL DEFAULT 0,
    [Break] BIT NULL DEFAULT 0 
)
