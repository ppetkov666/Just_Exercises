CREATE DATABASE MyDataBaseSample
GO 
CREATE TABLE UserInfo(
	Id INT PRIMARY KEY IDENTITY,
	UserName NVARCHAR(50) NOT NULL,
	[Password] VARCHAR(MAX) NOT NULL, 
	Email VARCHAR(MAX) NOT NULL,
	[Address] VARCHAR(MAX) NOT NULL,
	Town VARCHAR(50) NOT NULL
)
INSERT INTO UserInfo
VALUES 
('updatedfromDB','dbpass','first@aol.com','FirstStreet1','North Carolina'),
('FirstUser','123456','first@aol.com','FirstStreet1','New York'),
('SecondUser','12345','second@aol.com','secondStreet1','Vegas'),
('ThirdUser','1234','third@aol.com','thirdStreet1','Toronto'),
('FourthtUser','123','fourth@aol.com','fourthStreet1','LA')

select * from UserInfo
