CREATE TABLE [dbo].[users] (
    [user_id]       INT           IDENTITY (1, 1) NOT NULL,
    [first_name]    VARCHAR (25)  NOT NULL,
    [middle_names]  VARCHAR (50)  DEFAULT (NULL) NULL,
    [last_name]     VARCHAR (25)  NOT NULL,
    [email_address] VARCHAR (100) NOT NULL,
    [mobile_number] VARCHAR (15)  NOT NULL,
    [work_number]   VARCHAR (15)  DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);
