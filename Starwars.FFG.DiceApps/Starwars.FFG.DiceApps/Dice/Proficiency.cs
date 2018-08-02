using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps.Dice
{
    public class Proficiency : Dice
    {
        public Proficiency()
        {
            this.di = DiceOptions.Proficiency;
            this.sides = 12;
            this.rand = new Random();
        }

        public new ResultOptions GetOutcome(int check)
        {
            switch(check)
            {
                case 1:
                    return ResultOptions.Blank;
                case 2:
                    return ResultOptions.Success;
                case 3:
                    return ResultOptions.Success;
                case 4:
                    return ResultOptions.TwoSuccesses;
                case 5:
                    return ResultOptions.TwoSuccesses;
                case 6:
                    return ResultOptions.Advantage;
                case 7:
                    return ResultOptions.Success | ResultOptions.Advantage;
                case 8:
                    return ResultOptions.Success | ResultOptions.Advantage;
                case 9:
                    return ResultOptions.Success | ResultOptions.Advantage;
                case 10:
                    return ResultOptions.TwoAdvantages;
                case 11:
                    return ResultOptions.TwoAdvantages;
                case 12:
                    return ResultOptions.Triumph;
                default:
                    return ResultOptions.Blank;
            }
        }
    }
}
