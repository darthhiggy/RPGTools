GO  

--Creates Main working tables
--Delete the Armor table if it exists.  
IF EXISTS(SELECT * from sys.tables WHERE name='Armor')  
BEGIN  
    DROP TABLE Armor;  
END  

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

GO  


CREATE TABLE Armor (
	[Aggregateid] int Primary Key not null
	, [Type] INT
	, CONSTRAINT FK_ArmorTypes_AggregateId Foreign Key (Type)
		REFERENCES ArmorTypes (AggregateId)
		ON UPDATE CASCADE
	, [Name] VARCHAR(50)
	, [Soak] int
	, [Defense] int
	, [Encumberance] int
	, [HardPoints] int
	, [Price] int
	, [Rarity] int
	, [IsRestricted] bit default 0
	, [Qualties] VARCHAR(MAX) 
	, [Description] VARCHAR(MAX)
	, [Book] VARCHAR(50)
)

-- Creates Temp Temp Tables for imports

GO  

--Delete the TempLightArmor table if it exists.  
IF EXISTS(SELECT * from sys.tables WHERE name='TempLightArmor')  
BEGIN  
    DROP table TempLightArmor;  
END  

CREATE TABLE TempLightArmor 
(
	[Name] Varchar(max)
	,Soak Varchar(max)	
	,Def Varchar(max)	
	,Enc Varchar(max)	
	,HP	Varchar(max)
	,Price Varchar(max)	
	,Rarity	Varchar(max)
	,Qualities Varchar(max)	
	,Book Varchar(max)

)

IF EXISTS(SELECT * from sys.tables WHERE name='TempMediumArmor')  
BEGIN  
    DROP table TempMediumArmor;  
END  

CREATE TABLE TempMediumArmor 
(
	[Name] Varchar(max)
	,Soak Varchar(max)	
	,Def Varchar(max)	
	,Enc Varchar(max)	
	,HP	Varchar(max)
	,Price Varchar(max)	
	,Rarity	Varchar(max)
	,Qualities Varchar(max)	
	,Book Varchar(max)

)
	