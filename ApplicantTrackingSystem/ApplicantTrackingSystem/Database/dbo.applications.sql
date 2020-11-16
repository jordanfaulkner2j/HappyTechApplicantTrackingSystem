CREATE TABLE [dbo].[applications] (
    [application_id] INT  IDENTITY (1, 1) NOT NULL,
    [applicant_id]   INT  NOT NULL,
    [employee_id]    INT  DEFAULT (NULL) NULL,
    [date_submitted] DATE NOT NULL,
    [interviewed]    BIT  NOT NULL,
    [feedback_left]  BIT  NOT NULL,
    [feedback_sent]  BIT  NOT NULL,
    PRIMARY KEY CLUSTERED ([application_id] ASC),
    CONSTRAINT [FK_applications_ToTable] FOREIGN KEY ([applicant_id]) REFERENCES [dbo].[applicant] ([applicant_id]),
    CONSTRAINT [FK_applications_ToTable_1] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[employee] ([employee_id])
);
