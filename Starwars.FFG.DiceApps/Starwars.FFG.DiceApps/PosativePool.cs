using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starwars.FFG.DiceApps.Dice;

namespace Starwars.FFG.DiceApps
{
    public class PosativePool
    {
        public int ablDice, bstDice, profDice;
        public int[] posativeOutcome = new int[3];
        public Ability ability;
        public Boost boost;
        public Proficiency proficiency;

        public PosativePool(int ablDice, int bstDice, int profDice)
        {
            this.ablDice = ablDice;
            this.bstDice = bstDice;
            this.profDice = profDice;
            ability = new Ability();
            boost = new Dice.Boost();
            proficiency = new Proficiency();
            for(int i = 0; i < posativeOutcome.Length; i++)
            {
                posativeOutcome[i] = 0;
            }
        }

        public int[] Roll()
        {
            var tasks = new List<Task>();
            tasks.Add(Task.Factory.StartNew<bool>(() =>
            {
                return AbilityRoll();
            }));

            tasks.Add(Task.Factory.StartNew<bool>(() =>
            {
                return BoostRoll();
            }));

            tasks.Add(Task.Factory.StartNew<bool>(() =>
            {
                return ProficiencyRoll();
            }));

            Task.WaitAll(tasks.ToArray());

            return posativeOutcome;
        }

        public bool AbilityRoll()
        {
            try
            {
                for (int i = 0; i < ablDice; i++)
                {
                    ParseRoll(ability.Roll());
                }
            }
            catch(Exception exc)
            {
                return false;
            }

            return true;
        }

        public bool BoostRoll()
        {
            try
            {
                for (int i = 0; i < bstDice; i++)
                {
                    ParseRoll(ability.Roll());
                }
            }
            catch (Exception exc)
            {
                return false;
            }

            return true;
        }

        public bool ProficiencyRoll()
        {
            try
            {
                for (int i = 0; i < profDice; i++)
                {
                    ParseRoll(proficiency.Roll());
                }
            }
            catch(Exception exc)
            {
                return false;
            }

            return true;
        }

        public void ParseRoll(ResultOptions outcome)
        {
            if((ResultOptions.Advantage & outcome) == ResultOptions.Advantage)
            {
                posativeOutcome[0]++;
            }
            if((ResultOptions.TwoAdvantages & outcome) == ResultOptions.TwoAdvantages)
            {
                posativeOutcome[0] += 2;
            }
            if((ResultOptions.Success & outcome) == ResultOptions.Success)
            {
                posativeOutcome[1]++;
            }
            if((ResultOptions.TwoSuccesses & outcome) == ResultOptions.TwoSuccesses)
            {
                posativeOutcome[1] += 2;
            }
            if((ResultOptions.Triumph & outcome) == ResultOptions.Triumph)
            {
                posativeOutcome[2]++;
            }
        }

        public override string ToString()
        {
            return "Successes : " + posativeOutcome[1] + "; Advantages : " + posativeOutcome[0] + "; Triumphs : " + posativeOutcome[2] + ";"; 
        }
    }
}
