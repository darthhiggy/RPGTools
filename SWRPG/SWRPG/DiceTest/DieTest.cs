using System;
using Dice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTest
{
    [TestClass]
    public class DieTest
    {
        [TestMethod]
        public void SidesTest()
        {
            // Declare 
            var ability = new Die(DiceType.Ability);
            var boost = new Die(DiceType.Boost);
            var challenge = new Die(DiceType.Challenge);
            var difficulty = new Die(DiceType.Difficulty);
            var force = new Die(DiceType.Force);
            var proficiency = new Die(DiceType.Proficiency);
            var setback = new Die(DiceType.Setback);
            var tensided = new Die(DiceType.TenSided);

            // Setup
            var ablSides = 8;
            var boostSides = 6;
            var chlgSides = 12;
            var diffSides = 8;
            var forceSides = 12;
            var profSides = 12;
            var setbackSides = 6;
            var percentSides = 10;

            // Assert
            Assert.AreEqual(ablSides, ability.Sides);
            Assert.AreEqual(boostSides, boost.Sides);
            Assert.AreEqual(chlgSides, challenge.Sides);
            Assert.AreEqual(diffSides, difficulty.Sides);
            Assert.AreEqual(forceSides, force.Sides);
            Assert.AreEqual(profSides, proficiency.Sides);
            Assert.AreEqual(setbackSides, setback.Sides);
            Assert.AreEqual(percentSides, tensided.Sides);
        }
    }
}
