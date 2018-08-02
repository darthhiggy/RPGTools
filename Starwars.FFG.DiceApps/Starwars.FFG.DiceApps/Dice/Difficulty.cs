using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps.Dice
{
    public class Difficulty : Dice
    {
        public Difficulty()
        {
            this.di = DiceOptions.Difficulty;
            this.sides = 8;
            this.rand = new Random();
        }

        public new ResultOptions GetOutcome(int check)
        {
            switch(check)
            {
                case 1:
                    return ResultOptions.Blank;
                case 2:
                    return ResultOptions.Failure;
                case 3:
                    return ResultOptions.TwoFailures;
                case 4:
                    return ResultOptions.Threat;
                case 5:
                    return ResultOptions.Threat;
                case 6:
                    return ResultOptions.Threat;
                case 7:
                    return ResultOptions.TwoThreat;
                case 8:
                    return ResultOptions.Failure | ResultOptions.Threat;
                default:
                    return ResultOptions.Blank;
            }
        }
    }
}
