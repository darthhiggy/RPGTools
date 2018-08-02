GO  

--Delete the Armortypes database if it exists.  
IF EXISTS(SELECT * from sys.tables WHERE name='ArmorTypes')  
BEGIN  
    DROP TABLE ArmorTypes;  
END  

GO

CREATE TABLE ArmorTypes (
	AggregateId int IDENTITY(1,1) PRIMARY KEY not null
	, [Type] VARCHAR(50)
)

INSERT INTO ArmorTypes
VALUES ('Light')
	, ('Medium')
	, ('Heavy')
	,('Special')
	,('Beast')

SELECT *
FROM ArmorTypes

