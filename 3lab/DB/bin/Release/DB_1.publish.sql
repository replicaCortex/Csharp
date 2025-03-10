/*
Скрипт развертывания для freakBD

Этот код был создан программным средством.
Изменения, внесенные в этот файл, могут привести к неверному выполнению кода и будут потеряны
в случае его повторного формирования.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "freakBD"
:setvar DefaultFilePrefix "freakBD"
:setvar DefaultDataPath "C:\Users\replica\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\replica\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Проверьте режим SQLCMD и отключите выполнение скрипта, если режим SQLCMD не поддерживается.
Чтобы повторно включить скрипт после включения режима SQLCMD выполните следующую инструкцию:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Для успешного выполнения этого скрипта должен быть включен режим SQLCMD.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Идет создание Таблица [dbo].[Car]…';


GO
CREATE TABLE [dbo].[Car] (
    [Id]       INT           NOT NULL,
    [Model]    NVARCHAR (10) NULL,
    [Places]   INT           NULL,
    [Drive]    BIT           NULL,
    [EngineId] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Идет создание Ограничение по умолчанию ограничение без названия для [dbo].[Car]…';


GO
ALTER TABLE [dbo].[Car]
    ADD DEFAULT 'None' FOR [Model];


GO
PRINT N'Идет создание Ограничение по умолчанию ограничение без названия для [dbo].[Car]…';


GO
ALTER TABLE [dbo].[Car]
    ADD DEFAULT 0 FOR [Places];


GO
PRINT N'Идет создание Ограничение по умолчанию ограничение без названия для [dbo].[Car]…';


GO
ALTER TABLE [dbo].[Car]
    ADD DEFAULT 0 FOR [Drive];


GO
PRINT N'Идет создание Внешний ключ [dbo].[FK_Cars_Machines]…';


GO
ALTER TABLE [dbo].[Car] WITH NOCHECK
    ADD CONSTRAINT [FK_Cars_Machines] FOREIGN KEY ([Id]) REFERENCES [dbo].[Machines] ([Id]) ON DELETE CASCADE;


GO
PRINT N'Идет создание Внешний ключ [dbo].[FK_Cars_Engines]…';


GO
ALTER TABLE [dbo].[Car] WITH NOCHECK
    ADD CONSTRAINT [FK_Cars_Engines] FOREIGN KEY ([EngineId]) REFERENCES [dbo].[Engines] ([Id]);


GO
PRINT N'Существующие данные проверяются относительно вновь созданных ограничений';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Car] WITH CHECK CHECK CONSTRAINT [FK_Cars_Machines];

ALTER TABLE [dbo].[Car] WITH CHECK CHECK CONSTRAINT [FK_Cars_Engines];


GO
PRINT N'Обновление завершено.';


GO
