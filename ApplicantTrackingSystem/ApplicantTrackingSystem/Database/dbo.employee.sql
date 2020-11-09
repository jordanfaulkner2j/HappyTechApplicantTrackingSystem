CREATE TABLE [dbo].[employee] (
    [employee_id]   INT           IDENTITY (1, 1) NOT NULL,
    [user_id]       INT           NOT NULL,
    [job_title]     VARCHAR (25)  NOT NULL,
    [password]      VARCHAR (256) NOT NULL,
    [administrator] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([employee_id] ASC), 
    CONSTRAINT [FK_employee_ToTable] FOREIGN KEY ([user_id]) REFERENCES [dbo].[users]([user_id])
);
