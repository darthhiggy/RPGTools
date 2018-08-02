using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starwars.FFG.DiceApps.Dice;

namespace Starwars.FFG.DiceApps
{
    public class NegativePool
    {
        public int diffDice, setBackDice, challDice;
        public int[] negativeOutcome = new int[3];
        public Difficulty difficulty;
        public Setback setback;
        public Challenge challenge;

        public NegativePool(int diff, int setb, int chall)
        {
            this.diffDice = diff;
            this.setBackDice = setb;
            this.challDice = chall;
            difficulty = new Difficulty();
            setback = new Setback();
            challenge = new Challenge();
            for(int i = 0; i < negativeOutcome.Length; i++)
            {
                negativeOutcome[i] = 0;
            }
        }

        public int[] Roll()
        {

            return negativeOutcome;
        }

        public bool DifficultyRoll()
        {
            try
            {
                for (int i = 0; i < diffDice; i++)
                {
                    ParseRoll(difficulty.Roll());
                }
            }
            catch (Exception exc)
            {
                return false;
            }

            return true;
        }

        public void ParseRoll(ResultOptions result)
        {
            if((ResultOptions.Threat & result) == ResultOptions.Threat)
            {
                negativeOutcome[0]++;
            }
            if((ResultOptions.TwoThreat & result) == ResultOptions.TwoThreat)
            {
                negativeOutcome[0] += 2;
            }
            if((ResultOptions.Failure & result) == ResultOptions.Failure)
            {
                negativeOutcome[1]++;
            }
            if((ResultOptions.TwoFailures & result) == ResultOptions.TwoFailures)
            {
                negativeOutcome[1] += 2;
            }
            if((ResultOptions.Despair & result) == ResultOptions.Despair)
            {
                negativeOutcome[2]++;
            }
        }
    }
}
