CREATE TABLE [dbo].[ProgramInArchives]
(
	[ProgramID] INT NOT NULL,
    [ArchivesID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ArchivesID] ASC, [ProgramID] ASC),
    CONSTRAINT [ArchivesID] FOREIGN KEY ([ArchivesID]) REFERENCES [dbo].[Archives] ([Id]),
    CONSTRAINT [ProgramID] FOREIGN KEY ([ProgramID]) REFERENCES [dbo].[Program] ([Id])
);
