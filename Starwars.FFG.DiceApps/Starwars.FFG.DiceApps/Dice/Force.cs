using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps.Dice
{
    public class Force : Dice
    {
        public Force()
        {
            this.di = DiceOptions.Force;
            this.sides = 12;
            this.rand = new Random();
        }

        public new ResultOptions GetOutcome(int check)
        {
            switch(check)
            {
                case 1:
                    return ResultOptions.DarkSide;
                case 2:
                    return ResultOptions.DarkSide;
                case 3:
                    return ResultOptions.DarkSide;
                case 4:
                    return ResultOptions.DarkSide;
                case 5:
                    return ResultOptions.DarkSide;
                case 6:
                    return ResultOptions.DarkSide;
                case 7:
                    return ResultOptions.TwoDarkside;
                case 8:
                    return ResultOptions.LightSide;
                case 9:
                    return ResultOptions.LightSide;
                case 10:
                    return ResultOptions.TwoLightSide;
                case 11:
                    return ResultOptions.TwoLightSide;
                case 12:
                    return ResultOptions.TwoLightSide;
                default:
                    return ResultOptions.Blank;
            }
        }
    }
}
