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

declare @recordCount int = 0

UPDATE tempLightArmor SET
	Aggregateid = @recordCount
	,@recordCount = @recordCount + 1

BULK
INSERT TempMediumArmor
FROM 'D:\OneDrive\Documents\repos\RPGTools\CVSScripts\MediumArmor.csv'
WITH
(
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
)

ALTER TABLE tempMediumArmor ADD Aggregateid int

GO

declare @recordCount int = 0

UPDATE tempLightArmor SET
	Aggregateid = @recordCount
	,@recordCount = @recordCount + 1