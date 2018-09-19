using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class Die : IDie
    {
        private int _sides;
        public int Sides
        {
            get
            {
                if(_sides <= 0)
                {
                    switch (Type)
                    {
                        case DiceType.Ability:
                            _sides = 8;
                            break;
                        case DiceType.Proficiency:
                            _sides = 12;
                            break;
                        case DiceType.Boost:
                            _sides = 6;
                            break;
                        case DiceType.Difficulty:
                            _sides = 8;
                            break;
                        case DiceType.Challenge:
                            _sides = 12;
                            break;
                        case DiceType.Setback:
                            _sides = 6;
                            break;
                        case DiceType.Force:
                            _sides = 12;
                            break;
                        case DiceType.TenSided:
                            _sides = 10;
                            break;
                        default:
                            break;
                    }
                }
                return _sides;
            }

            set
            {
                switch (Type)
                {
                    case DiceType.Ability:
                        _sides = 8;
                        break;
                    case DiceType.Proficiency:
                        _sides = 12;
                        break;
                    case DiceType.Boost:
                        _sides = 6;
                        break;
                    case DiceType.Difficulty:
                        _sides = 8;
                        break;
                    case DiceType.Challenge:
                        _sides = 12;
                        break;
                    case DiceType.Setback:
                        _sides = 6;
                        break;
                    case DiceType.Force:
                        _sides = 12;
                        break;
                    case DiceType.TenSided:
                        _sides = 10;
                        break;
                    default:
                        break;
                }
            }
        }
        public DiceType Type {get; set;}

        public Die(DiceType type)
        {
            this.Type = type;
            
        }

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, (Sides + 1));
        }
    }
}
