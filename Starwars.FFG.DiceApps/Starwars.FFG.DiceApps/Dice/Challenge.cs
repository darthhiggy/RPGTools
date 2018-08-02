using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps.Dice
{
    public class Challenge : Dice
    {
        public Challenge()
        {
            this.di = DiceOptions.Challenge;
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
                    return ResultOptions.Failure;
                case 3:
                    return ResultOptions.Failure;
                case 4:
                    return ResultOptions.TwoFailures;
                case 5:
                    return ResultOptions.TwoFailures;
                case 6:
                    return ResultOptions.Threat;
                case 7:
                    return ResultOptions.Threat;
                case 8:
                    return ResultOptions.Failure | ResultOptions.Threat;
                case 9:
                    return ResultOptions.Failure | ResultOptions.Threat;
                case 10:
                    return ResultOptions.TwoThreat;
                case 11:
                    return ResultOptions.TwoThreat;
                case 12:
                    return ResultOptions.Despair;
                default:
                    return ResultOptions.Blank;
            }
        }
    }
}
