﻿CREATE TABLE [dbo].[Players] (
    [Id]            INT  NULL,
    [Name]          TEXT NOT NULL,
    [Age]           INT  NOT NULL,
    [Sex]           TEXT NOT NULL,
    [LPZ]           INT  NOT NULL,
    [Blocked]       BIT  DEFAULT ((0)) NOT NULL,
    [Availability]  INT  DEFAULT ((100)) NULL,
    [PlayedMatches] INT  NOT NULL,
    [Phone]         TEXT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

