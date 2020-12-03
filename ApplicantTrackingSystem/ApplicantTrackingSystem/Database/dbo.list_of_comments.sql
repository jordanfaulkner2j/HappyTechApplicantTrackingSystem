CREATE TABLE [dbo].[list_of_comments] (
    [comment_id]  INT NOT NULL,
    [template_id] INT NOT NULL, 
    CONSTRAINT [FK_list_of_comments_ToTable] FOREIGN KEY ([comment_id]) REFERENCES [dbo].[comment] ([comment_id]) ON DELETE CASCADE, 
    CONSTRAINT [FK_list_of_comments_ToTable_1] FOREIGN KEY ([template_id]) REFERENCES [dbo].[template] ([template_id]) ON DELETE CASCADE 
);
