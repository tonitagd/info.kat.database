CREATE TABLE [dbo].[Fines]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Type] NVARCHAR(50) NOT NULL, 
    [SerialNumber] NVARCHAR(50) NOT NULL, 
    [Date] NVARCHAR(50) NOT NULL, 
    [Policeman] NVARCHAR(50) NOT NULL, 
    [OffenderDLN] NVARCHAR(50) NOT NULL, 
    [Paid] TINYINT NOT NULL
)
