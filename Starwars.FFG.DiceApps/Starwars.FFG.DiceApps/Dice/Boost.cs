using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps.Dice
{
    public class Boost : Dice
    {
        public Boost()
        {
            this.di = DiceOptions.Boost;
            this.sides = 6;
            this.rand = new Random();
        }

        public new ResultOptions GetOutcome(int check)
        {
            switch(check)
            {
                case 1:
                    return ResultOptions.Blank;
                case 2:
                    return ResultOptions.Blank;
                case 3:
                    return ResultOptions.Success;
                case 4:
                    return ResultOptions.Success | ResultOptions.Advantage;
                case 5:
                    return ResultOptions.TwoAdvantages;
                case 6:
                    return ResultOptions.Advantage;
                default:
                    return ResultOptions.Blank;
            }
        }
    }
}
