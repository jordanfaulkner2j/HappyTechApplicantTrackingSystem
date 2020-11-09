CREATE TABLE [dbo].[job_position] (
    [job_position_id]  INT             IDENTITY (1, 1) NOT NULL,
    [title]            VARCHAR (25)    NOT NULL,
    [job_requirements] TEXT            NOT NULL,
    [responsibilities] TEXT            NOT NULL,
    [salary]           DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([job_position_id] ASC)
);
