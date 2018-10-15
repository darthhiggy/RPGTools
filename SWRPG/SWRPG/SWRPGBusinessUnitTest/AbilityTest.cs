using System;
using SWRPG.Buisness.Abilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SWRPGBusinessUnitTest
{
    [TestClass]
    public class AbilityTest
    {
        [TestMethod]
        public void AbilityRepositoryTest()
        {
            // Arrange
            var ability = new Ability(1);
            ability.AbilityName = "Strength";
            ability.Description = "How Strong You Are";
            // Act
            var ablRepository = new AbilityRepository();
            var abl = ablRepository.Retrieve(1);
            // Assert
            Assert.AreEqual(ability.AbilityName, abl.AbilityName);
            Assert.AreEqual(ability.Description, abl.Description);
        }
    }
}
