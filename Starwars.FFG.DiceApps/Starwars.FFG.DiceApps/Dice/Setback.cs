using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps.Dice
{
    public class Setback : Dice
    {
        public Setback()
        {
            this.di = DiceOptions.Setback;
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
                    return ResultOptions.Blank;
                case 4:
                    return ResultOptions.Failure;
                case 5:
                    return ResultOptions.Threat;
                case 6:
                    return ResultOptions.Threat;
                default:
                    return ResultOptions.Blank;
                   
            }
        }
    }
}
