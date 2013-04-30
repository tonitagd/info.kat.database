CREATE TABLE [dbo].[Users] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Username]        NVARCHAR (50) NOT NULL,
    [Password]        NVARCHAR (50) NOT NULL,
    [DrivingLicenseN] NVARCHAR (50) NOT NULL,
    [Role] SMALLINT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

