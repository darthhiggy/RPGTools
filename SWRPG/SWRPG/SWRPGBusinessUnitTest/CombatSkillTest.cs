using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWRPG.Buisness.Skills;
using SWRPG.Buisness.Abilities;

namespace SWRPGBusinessUnitTest
{
    [TestClass]
    public class CombatSkillTest
    {
        [TestMethod]
        public void CombatSkillRepositoryTest()
        {
            // Arrange
            var combatSkill = new CombatSkill(1)
            {
                SkillName = "Melee",
                SkillAbility = new AbilityRepository().Retrieve(1),
                Description = "Hit people good"
            };

            // Act
            var cmbSkillRepository = new CombatSkillRepository();
            var cmbSkill = cmbSkillRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(combatSkill.Description, cmbSkill.Description);
            Assert.AreEqual(combatSkill.SkillAbility.AbilityName, cmbSkill.SkillAbility.AbilityName);
            Assert.AreEqual(combatSkill.SkillAbility.Description, cmbSkill.SkillAbility.Description);
            Assert.AreEqual(combatSkill.SkillName, cmbSkill.SkillName);
        }
    }
}
