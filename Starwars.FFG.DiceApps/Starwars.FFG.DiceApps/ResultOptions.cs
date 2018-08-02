using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps
{
    public enum ResultOptions
    {
        Blank = 0,
        Success = 1,
        TwoSuccesses = 2, 
        Advantage = 4,
        TwoAdvantages = 8,
        Triumph = 16,
        Failure = 32,
        TwoFailures = 64,
        Threat = 128,
        TwoThreat = 256,
        Despair = 512,
        LightSide = 1024,
        TwoLightSide = 2048,
        DarkSide = 4096,
        TwoDarkside = 8192,

        Posative = Success | TwoSuccesses | Advantage | TwoAdvantages | Triumph,
        Negateive = Failure | TwoFailures | Threat | TwoThreat | Despair,
        Force = LightSide | TwoLightSide | DarkSide | TwoDarkside
    }
}
