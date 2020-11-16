CREATE TABLE [dbo].[feedback] (
    [feedback_id]    INT  IDENTITY (1, 1) NOT NULL,
    [application_id] INT  NOT NULL,
    [template_id]    INT  NOT NULL,
    [date_created]   DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([feedback_id] ASC), 
    CONSTRAINT [FK_feedback_ToTable] FOREIGN KEY ([application_id]) REFERENCES [dbo].[applications] ([application_id]), 
    CONSTRAINT [FK_feedback_ToTable_1] FOREIGN KEY ([template_id]) REFERENCES [dbo].[template] ([template_id])
);
