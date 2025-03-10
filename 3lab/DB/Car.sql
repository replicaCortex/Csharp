CREATE TABLE [dbo].[Cars] (
    [Id] INT NOT NULL PRIMARY KEY,
    [Model] NVARCHAR(10) NULL DEFAULT 'None',
    [Places] INT NULL DEFAULT 0,
    [Drive] BIT NULL DEFAULT 0,
    [EngineId] INT NULL,

    -- Внешние ключи
    -- CONSTRAINT FK_Cars_Machines FOREIGN KEY ([Id]) REFERENCES [dbo].[Machines]([Id]) ON DELETE CASCADE,
    -- CONSTRAINT FK_Cars_Engines FOREIGN KEY ([EngineId]) REFERENCES [dbo].[Engines]([Id])
);