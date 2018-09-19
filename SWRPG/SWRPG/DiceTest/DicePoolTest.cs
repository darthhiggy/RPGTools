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
                Console.WriteLine($"{res} : {result[res]}");
            }

            // Assert
            Assert.AreEqual(8, result.Count);
            Assert.AreEqual(7, pool.Pool.Count);
        }

        [TestMethod]
        public void BoostDieTest()
        {
            // Declare
            var pool = new DicePool();
            pool.AddDie(DiceType.Boost);

            // Setup
            var results = pool.Roll();

            foreach(var res in results.Keys)
            {
                Console.WriteLine($"{res} : {results[res]}");
            }

            // Assert
            Assert.IsTrue(results[ResultTypes.DarkPoint] == 0);
            Assert.IsTrue(results[ResultTypes.Dispair] == 0);
            Assert.IsTrue(results[ResultTypes.Failure] == 0);
            Assert.IsTrue(results[ResultTypes.LightPoint] == 0);
            Assert.IsTrue(results[ResultTypes.Threat] == 0);
            Assert.IsTrue(results[ResultTypes.Triumph] == 0);

        }
    }
}
