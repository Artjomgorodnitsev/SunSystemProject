CREATE TABLE [dbo].[Records] (
    [Id]              INT        IDENTITY (1, 1) NOT NULL,
    [Name]            NCHAR (30) NULL,
    [Points]          INT        NULL DEFAULT 0,
    [Level]           INT        NULL DEFAULT 0,
    [CorrectAnswer]   INT        NULL DEFAULT 0,
    [IncorrectAnswer] INT        NULL DEFAULT 0,
    [Date]            DATE       NULL DEFAULT 0,
    [Time]            TIME (7)   NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

