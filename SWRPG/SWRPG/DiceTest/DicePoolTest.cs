using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dice;

namespace DiceTest
{
    [TestClass]
    public class DicePoolTest
    {
        [TestMethod]
        public void DiceRollTest()
        {
            // Declare

            var pool = new DicePool();
            pool.AddDie(DiceType.Ability);
            pool.AddDie(DiceType.Boost);
            pool.AddDie(DiceType.Challenge);
            pool.AddDie(DiceType.Difficulty);
            pool.AddDie(DiceType.Force);
            pool.AddDie(DiceType.Proficiency);
            pool.AddDie(DiceType.Setback);


            // Setup

            var result = pool.Roll();

            foreach(var res in result.Keys)
            {
                Console.WriteLine(result[res]);
            }

            // Assert
            Assert.AreEqual(7, result.Count);
        }
    }
}
