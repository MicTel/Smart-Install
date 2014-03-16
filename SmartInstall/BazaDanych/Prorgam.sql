CREATE TABLE [dbo].[Program] (
    [Id]          INT           NOT NULL,
    [Name]        VARCHAR (50)  NULL,
    [Version]     VARCHAR (50)  NULL,
    [Description] VARCHAR (MAX) NULL,
    [HelpLink]    VARCHAR (MAX) NULL,
    [URLUpdate]   VARCHAR (MAX) NULL,
    [Publisher]   VARCHAR (50)  NULL,
    [Icon]        VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

