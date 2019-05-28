use sqlpractice
go

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Business') 
DROP TABLE Business 
GO

CREATE TABLE Business
(
	BusinessID INT Primary Key,
	ActivityNature VARCHAR(30)
	constraint chk_donar_activity CHECK(ActivityNature IN('Health','Trade',
		'Water Tanker')),
	MobileNo VARCHAR(10),
	EmailID VARCHAR(30),
	ApplicantName VARCHAR(30)
)
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcBusinessIdAutoGenerate') 
DROP PROC prcBusinessIdAutoGenerate
GO


CREATE PROC prcBusinessIdAutoGenerate
AS
BEGIN
	SELECT CASE WHEN MAX(BusinessID) IS NULL THEN 1 ELSE 
	MAX(BusinessID) END DonarID  FROM Business
END
Go

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='PrcBusinessInsert') 
DROP PROC PrcBusinessInsert
GO
CREATE PROC PrcBusinessInsert
					@BusinessID INT,
					@ActivityNature VARCHAR(30),
					@MobileNo VARCHAR(10),
					@EmailID VARCHAR(30),
					@ApplicantName VARCHAR(15)
AS
BEGIN
	INSERT INTO Business VALUES(@BusinessID,@ActivityNature,@MobileNo,@EmailID,
				@ApplicantName)
END
GO