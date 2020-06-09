CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(30) NULL, 
    [Points] INT NULL, 
    [Level] INT NULL, 
    [CorrectAnswer] INT NULL, 
    [IncorrectAnswer] INT NULL, 
    [Date] DATE NULL, 
    [Time] TIME NULL
)
