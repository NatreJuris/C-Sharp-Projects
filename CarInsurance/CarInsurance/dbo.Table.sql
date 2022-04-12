CREATE TABLE [dbo].[Table] (
    [Id]              INT NOT NULL,
    [FirstName]       NVARCHAR (50) NOT NULL,
    [LasstName]       NVARCHAR (50) NOT NULL,
    [EmailAddress]    NVARCHAR (50) NOT NULL,
    [DateOfBirth]     DATETIME      NOT NULL,
    [CarYear]         INT           NOT NULL,
    [CarMake]         NVARCHAR (50) NOT NULL,
    [CarModel]        NVARCHAR (50) NOT NULL,
    [DUI]             BIT           NOT NULL,
    [SpeedingTickets] INT           NOT NULL,
    [CoverageType]    BIT           NOT NULL,
    [Quote]           MONEY         NULL IDENTITY DEFAULT {0}



























    PRIMARY KEY CLUSTERED ([Id] ASC)
);

