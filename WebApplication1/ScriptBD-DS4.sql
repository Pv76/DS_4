USE master;
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'GitHubSearchDB')
BEGIN
    CREATE DATABASE GitHubSearchDB;
END
GO

USE GitHubSearchDB;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SearchHistory')
BEGIN
    CREATE TABLE SearchHistory (
        SearchID INT PRIMARY KEY IDENTITY(1,1),
        Username NVARCHAR(100) NOT NULL UNIQUE,
        Name NVARCHAR(255),
        AvatarUrl NVARCHAR(500),
        Followers INT,
        PublicRepos INT,
        SearchDate DATETIME DEFAULT GETDATE(),
        LastSearched DATETIME DEFAULT GETDATE()
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Username' AND object_id = OBJECT_ID('SearchHistory'))
BEGIN
    CREATE INDEX IX_Username ON SearchHistory(Username);
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_LastSearched' AND object_id = OBJECT_ID('SearchHistory'))
BEGIN
    CREATE INDEX IX_LastSearched ON SearchHistory(LastSearched DESC);
END
GO
