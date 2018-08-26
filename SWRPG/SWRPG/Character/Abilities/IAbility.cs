using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Abilities
{
    public interface IAbility
    {
        AbilityTypes Name { get; set; }

        int Rank { get; set; }
    }
}
