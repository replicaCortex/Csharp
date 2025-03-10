DELETE FROM Cars;
DELETE FROM Machines;
DELETE FROM Engines

DBCC CHECKIDENT ('[dbo].[Machines]', RESEED, 0);

