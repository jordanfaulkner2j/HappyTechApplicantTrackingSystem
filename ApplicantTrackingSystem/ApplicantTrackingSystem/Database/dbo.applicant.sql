CREATE TABLE [dbo].[applicant] (
    [applicant_id]              INT         IDENTITY (1, 1) NOT NULL,
    [user_id]                   INT         NOT NULL,
    [date_of_birth]             DATE        NOT NULL,
    [national_insurance_number] VARCHAR (9) NOT NULL,
    PRIMARY KEY CLUSTERED ([applicant_id]), 
    CONSTRAINT [FK_applicant_ToTable] FOREIGN KEY ([user_id]) REFERENCES [dbo].[users]([user_id])
);
