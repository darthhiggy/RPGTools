using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Starwars.FFG.DiceApps.Dice
{
    public class Ability : Dice
    {
        public Ability()
        {
            this.di = DiceOptions.Ability;
            this.sides = 8;
            this.rand = new Random();
        }

        public new ResultOptions GetOutcome(int check)
        {

            switch (check)
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
                    return ResultOptions.TwoAdvantages;
                default:
                    return ResultOptions.Blank;
            }
        }
    }
}
