CREATE TABLE [dbo].[Archives]
(
	[Id]              INT           NOT NULL,
    [Name]           VARCHAR (50)  NULL,
    [Path]         VARCHAR (MAX) NULL,
    [CreateDate]  DATETIME      NULL,
    [ModifiedDate] DATETIME      NULL,
    [Description]            VARCHAR (MAX) NULL,
    [LanguageID]        INT           NULL,
    [SystemID]       INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [LanguageID] FOREIGN KEY ([LanguageID]) REFERENCES [dbo].[Language] ([Id]),
    CONSTRAINT [SystemID] FOREIGN KEY ([SystemID]) REFERENCES [dbo].[System] ([Id])
)
