CREATE TABLE [dbo].[Car] (
    [Id] INT NOT NULL PRIMARY KEY,
    [Model] NVARCHAR(10) NULL DEFAULT 'None',
    [Places] INT NULL DEFAULT 0,

    -- Внешние ключи
    -- CONSTRAINT FK_Cars_Machines FOREIGN KEY ([Id]) REFERENCES [dbo].[Machines]([Id]) ON DELETE CASCADE,
    -- CONSTRAINT FK_Cars_Engines FOREIGN KEY ([EngineId]) REFERENCES [dbo].[Engines]([Id])
);