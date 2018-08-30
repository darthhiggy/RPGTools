using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class Die : IDie
    {
        public int Sides { get; set; }
        public DiceType Type {get; set;}

        public Die(int sides, DiceType type)
        {
            this.Sides = sides;
            this.Type = type;
        }

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, (Sides + 1));
        }
    }
}
