using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.FFG.DiceApps.Dice
{
    public class Dice
    {
        public DiceOptions di { get; set; }
        public int sides;
        public Random rand;
        
        //public Dice(DiceOptions di, int sides)
        //{
        //    this.di = di;
        //    this.sides = sides;
        //    rand = new Random();
        //}

        public ResultOptions Roll()
        {
            return GetOutcome(rand.Next(sides));
        }

        public ResultOptions GetOutcome(int check)
        {
            return ResultOptions.Blank;
        }
    }
}
