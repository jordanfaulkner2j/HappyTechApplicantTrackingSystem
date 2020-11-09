CREATE TABLE [dbo].[comment] (
    [comment_id] INT         IDENTITY (1, 1) NOT NULL,
    [section_id] INT         NOT NULL,
    [code]       VARCHAR (1) NOT NULL,
    [comment]    TEXT        NOT NULL,
    PRIMARY KEY CLUSTERED ([comment_id] ASC), 
    CONSTRAINT [FK_comment_ToTable] FOREIGN KEY ([section_id]) REFERENCES [dbo].[section] ([section_id])
);
