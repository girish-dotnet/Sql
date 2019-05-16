USE SQLPRACTICE

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Users')
DROP TABLE USERS 
GO
CREATE TABLE Users
(
   UserName varchar(30) PRIMARY KEY,
   [Password] VARCHAR(30) NOT NULL
)
GO
INSERT INTO Users VALUES('Bhargav','Naga'),
	('Sangeetha','Sangeetha'),
	('Arun','Yadav'),
	('Lakshmi','Sai')
GO

CREATE PROC PrcUserAuthenticate
						@userName VARCHAR(30),
						@passWord VARCHAR(30)
AS
BEGIN
	SELECT COUNT(*) FROM Users
	WHERE UserName=@userName AND PAssword=@passWord
END
GO