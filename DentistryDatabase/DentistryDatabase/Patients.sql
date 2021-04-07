CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NOT NULL, 
    [Sex] NCHAR(10) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [ContactNo] NCHAR(10) NOT NULL, 
    [MaritalStatus] NCHAR(10) NOT NULL, 
    [Occupation] NCHAR(10) NOT NULL, 
    [MedInfo] NVARCHAR(50) NOT NULL, 
    [Age] INT NOT NULL
)
