CREATE TABLE [dbo].[Drivers] (
    [Id]                   INT           NOT NULL,
    [FirstName]            NVARCHAR (50) NOT NULL,
    [MiddleName]           NVARCHAR (50) NOT NULL,
    [LastName]             NVARCHAR (50) NOT NULL,
    [IdNumber]             NCHAR (10)    NOT NULL,
    [BirthDate]            NVARCHAR (50) NOT NULL,
    [Gender]               NCHAR (10)    NOT NULL,
    [Address]              NVARCHAR (50) NOT NULL,
    [Country]              NVARCHAR (50) NOT NULL,
    [City]                 NVARCHAR (50) NOT NULL,
    [DrivingLicenseNumber] NCHAR (10)    NOT NULL,
    [DrivingCategories]    NVARCHAR (50) NOT NULL,
    [DrivingPointsLeft]    SMALLINT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

