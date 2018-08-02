
INSERT INTO Armor
SELECT [Aggregateid] = temp.Aggregateid
	   , [Type] = 1
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

INSERT INTO Armor
SELECT [Aggregateid] = temp.Aggregateid
	   , [Type] = 2
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
FROM tempMediumArmor as temp
