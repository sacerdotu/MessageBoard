CREATE TABLE [dbo].[tblUser]
(
UserID int IDENTITY(1,1) PRIMARY KEY,
FirstName NVARCHAR(100) NOT NULL,
LastName NVARCHAR(100) NOT NULL,
Username nvarchar(255) NOT NULL,
Password nvarchar(255) NOT NULL,
PasswordHash nvarchar(255) NOT NULL,
Country NVARCHAR(50) NOT NULL,
City NVARCHAR(50) NOT NULL,
Domain NVARCHAR(50) NOT NULL,
ProfileImage IMAGE,
IsAdministrator BIT NOT NULL,
IsActive BIT NOT NULL,
AccountCreation date NOT NULL 
);