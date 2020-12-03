CREATE TABLE [dbo].[application_for_job_position] (
    [job_position_id] INT NOT NULL,
    [application_id]  INT NOT NULL,
    CONSTRAINT [FK_application_for_job_position_ToTable] FOREIGN KEY ([application_id]) REFERENCES [dbo].[applications] ([application_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_application_for_job_position_ToTable_1] FOREIGN KEY ([job_position_id]) REFERENCES [dbo].[job_position] ([job_position_id]) ON DELETE NO ACTION
);

