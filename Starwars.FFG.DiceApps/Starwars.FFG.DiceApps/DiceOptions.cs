using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps
{
    public enum DiceOptions
    {
        Ability = 1, 
        Boost = 2, 
        Challenge = 4,
        Difficulty = 8,
        Force = 16,
        Proficiency = 32,
        Setback = 64,

        PosativeDice = Ability | Boost | Proficiency ,
        NegativeDice = Challenge | Difficulty | Setback
    }
}
