CREATE TABLE [dbo].[Vehicle] (
    [Id]                 INT           NOT NULL,
    [RegistryNumber]     NVARCHAR (10) NOT NULL,
    [FrameNumber]        NVARCHAR (20) NOT NULL,
    [EngineNumber]       NVARCHAR (10) NOT NULL,
    [Brand]              NVARCHAR (50) NOT NULL,
    [Model]              NVARCHAR (50) NOT NULL,
    [Type]               NVARCHAR (50) NOT NULL,
    [Seats]              SMALLINT      NOT NULL,
    [Weight]             INT           NOT NULL,
    [Color]              NVARCHAR (50) NOT NULL,
    [RegistryDate]       NVARCHAR (50) NOT NULL,
    [OwnerLicenseNumber] NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

