﻿CREATE TABLE [dbo].[section] (
    [section_id] INT         IDENTITY (1, 1) NOT NULL,
    [title]      VARCHAR (1) NOT NULL,
    PRIMARY KEY CLUSTERED ([section_id] ASC)
);