CREATE TABLE [dbo].[template] (
    [template_id] INT          IDENTITY (1, 1) NOT NULL,
    [title]       VARCHAR (50) NOT NULL,
    [header]      TEXT         NOT NULL,
    [footer]      TEXT         NOT NULL,
    PRIMARY KEY CLUSTERED ([template_id] ASC)
);

