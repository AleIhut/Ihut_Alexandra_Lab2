CREATE TABLE [dbo].[Book] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [Title]          NVARCHAR (MAX) NOT NULL,
    [Price]          DECIMAL (6, 2) NOT NULL,
    [PublishingDate] DATETIME2 (7)  DEFAULT ('0001-01-01T00:00:00.0000000') NOT NULL,
    [PublisherID]    INT            NULL,
    [AuthorID]       INT            NULL,
    CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Book_Publisher_PublisherID] FOREIGN KEY ([PublisherID]) REFERENCES [dbo].[Publisher] ([ID]),
    CONSTRAINT [FK_Book_Author_AuthorID] FOREIGN KEY ([AuthorID]) REFERENCES [dbo].[Author] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Book_PublisherID]
    ON [dbo].[Book]([PublisherID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Book_AuthorID]
    ON [dbo].[Book]([AuthorID] ASC);

