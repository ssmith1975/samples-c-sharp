
CREATE TABLE [dbo].[authors] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [lastname]  VARCHAR (50)  NULL,
    [firstname] VARCHAR (50)  NULL,
    [address]   VARCHAR (100) NULL,
    [city]      VARCHAR (100) NULL,
    [state]     CHAR (20)     NULL,
    [zip]       CHAR (5)      NULL,
    [phone]     VARCHAR (10)  NULL,
    [active]    BIT           NULL
);