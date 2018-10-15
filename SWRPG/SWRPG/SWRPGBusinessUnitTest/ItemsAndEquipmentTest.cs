using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWRPG.Buisness.ItemsAndEquipment;
using SWRPG.Buisness.Skills;

namespace SWRPGBusinessUnitTest
{
    [TestClass]
    public class ItemsAndEquipmentTest
    {
        [TestMethod]
        public void ItemQualitiesRetrieveTest()
        {
            // Arrange
            var quality = new ItemQualities(1)
            {
                Description = "Special",
                Passive = true,
                QualityName = "Speical Weapon"
            };

            // Act
            var qualityRepo = new ItemQualitiesRepository();
            var qual = qualityRepo.Retrieve(1);

            // Asert
            Assert.AreEqual(quality.Description, qual.Description);
            Assert.AreEqual(quality.Passive, qual.Passive);
            Assert.AreEqual(quality.QualityName, qual.QualityName);
        }

        [TestMethod]
        public void ItemQualitiesRetrieveListTest()
        {
            // Arrange
            var expectedQualList = new List<ItemQualities>();
            var expectedQual = new ItemQualities(1)
            {
                Description = "Special",
                Passive = true,
                QualityName = "Speical Weapon"
            };
            expectedQualList.Add(expectedQual);
            expectedQual = new ItemQualities(2)
            {
                Description = "Super Special",
                Passive = false,
                QualityName = "Super Speical Weapon"
            };
            expectedQualList.Add(expectedQual);

            // Act
            var actualQualRepository = new ItemQualitiesRepository();
            var actualQualList = actualQualRepository.Retrieve();

            // Assert
            for(int i = 0; i < actualQualList.Count; i++)
            {
                Assert.AreEqual(expectedQualList[i].Description, actualQualList[i].Description);
                Assert.AreEqual(expectedQualList[i].Passive, actualQualList[i].Passive);
                Assert.AreEqual(expectedQualList[i].QualityName, actualQualList[i].QualityName);
            }
        }

        [TestMethod]
        public void ArmorRetrieveTest()
        {
            // Arrange
            var expectedArmor = new Armor(1)
            {
                Defense = 1,
                Description = "Protects the wearer",
                Encumbrance = 2,
                Name = "Heavy Clothing",
                Price = 200,
                Rarity = 1,
                Soak = 1
            };
            // Act
            var actualArmorRepository = new ArmorRepository();
            var actualArmor = actualArmorRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedArmor.Defense, actualArmor.Defense);
            Assert.AreEqual(expectedArmor.Description, actualArmor.Description);
            Assert.AreEqual(expectedArmor.Encumbrance, actualArmor.Encumbrance);
            Assert.AreEqual(expectedArmor.Name, actualArmor.Name);
            Assert.AreEqual(expectedArmor.Price, actualArmor.Price);
            Assert.AreEqual(expectedArmor.Rarity, actualArmor.Rarity);
            Assert.AreEqual(expectedArmor.Soak, actualArmor.Rarity);

        }

        [TestMethod]
        public void GearRetrieveTest()
        {
            // Arrange
            var expectGear = new Gear(1)
            {
                Description = "See far away",
                Encumbrance = 1,
                Name = "Macrobinoculars",
                Price = 100,
                Rarity = 1
            };

            // Act
            var actualGearRepository = new GearRepository();
            var actualGear = actualGearRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectGear.Description, actualGear.Description);
            Assert.AreEqual(expectGear.Encumbrance, actualGear.Encumbrance);
            Assert.AreEqual(expectGear.Name, actualGear.Name);
            Assert.AreEqual(expectGear.Price, actualGear.Price);
            Assert.AreEqual(expectGear.Rarity, actualGear.Rarity);
        }

        [TestMethod]
        public void WeaponRetrieveTest()
        {
            // Arrange
            var combatSkillRepository = new CombatSkillRepository();
            var itemQualitiesRepository = new ItemQualitiesRepository();
            var expectedWeapon = new Weapon(1)
            {
                Name = "Baster Pistol",
                BaseDamage = 3,
                CriticalRating = 4,
                Description = "Fires blaster bolts",
                Encumbrance = 2,
                HardPoints = 2,
                Price = 400,
                Range = 2,
                Rarity = 3,
                Skill = combatSkillRepository.Retrieve(1),
                Special = itemQualitiesRepository.Retrieve()
            };
            // Act
            var actualWeaponRepository = new WeaponRepository();
            var actualWeapon = actualWeaponRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedWeapon.Name, actualWeapon.Name);
            Assert.AreEqual(expectedWeapon.BaseDamage, actualWeapon.BaseDamage);
            Assert.AreEqual(expectedWeapon.CriticalRating, actualWeapon.CriticalRating);
            Assert.AreEqual(expectedWeapon.Description, actualWeapon.Description);
            Assert.AreEqual(expectedWeapon.Encumbrance, actualWeapon.Encumbrance);
            Assert.AreEqual(expectedWeapon.HardPoints, actualWeapon.HardPoints);
            Assert.AreEqual(expectedWeapon.Price, actualWeapon.Price);
            Assert.AreEqual(expectedWeapon.Range, actualWeapon.Range);
            Assert.AreEqual(expectedWeapon.Rarity, actualWeapon.Rarity);
            Assert.AreEqual(expectedWeapon.Skill.Description, actualWeapon.Skill.Description);
            Assert.AreEqual(expectedWeapon.Skill.SkillName, actualWeapon.Skill.SkillName);
            Assert.AreEqual(expectedWeapon.Skill.SkillAbility.AbilityName, actualWeapon.Skill.SkillAbility.AbilityName);
            Assert.AreEqual(expectedWeapon.Skill.SkillAbility.Description, actualWeapon.Skill.SkillAbility.Description);

            for(int i = 0; i < expectedWeapon.Special.Count; i++)
            {
                Assert.AreEqual(expectedWeapon.Special[i].Description, actualWeapon.Special[i].Description);
                Assert.AreEqual(expectedWeapon.Special[i].Passive, actualWeapon.Special[i].Passive);
                Assert.AreEqual(expectedWeapon.Special[i].QualityName, actualWeapon.Special[i].QualityName);
            }
        }
    }
}
