GO  

--Delete the Armor table if it exists.  
IF EXISTS(SELECT * from sys.tables WHERE name='Armor')  
BEGIN  
    DROP TABLE Armor;  
END  

CREATE TABLE Armor (
	[Aggregateid] int Primary Key not null
	, [Type] VARCHAR(20)
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