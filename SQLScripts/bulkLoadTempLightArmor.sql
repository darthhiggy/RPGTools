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

BULK
INSERT TempLightArmor
FROM 'D:\OneDrive\Documents\repos\RPGTools\CVSScripts\lightArmor.csv'
WITH
(
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
)

ALTER TABLE tempLightArmor ADD Aggregateid int

GO
--Check the content of the table.
SELECT *
FROM TempLightArmor
GO

declare @recordCount int = 0

UPDATE tempLightArmor SET
	Aggregateid = @recordCount
	,@recordCount = @recordCount + 1

INSERT INTO Armor
SELECT [Aggregateid] = temp.Aggregateid
	   , [Type] = 'Light Armor'
	   , [Name] = temp.[Name]
	   , [Soak] = temp.[Soak]
	   , [Defense]  = temp.[Def]
	   , [Encumberance] = temp.[Enc]
	   , [HardPoints] = temp.[HP]
	   , [Price] = temp.[Price]
	   , [Rarity] = temp.[Rarity]
	   , [IsRestricted] = 0
	   , [Qualties] = temp.[Qualities]
	   , [Description] = ''
	   , [Book] = temp.[Book]
FROM tempLightArmor as temp

SELECT *
FROM Armor


