using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Abilities
{
    public class Ability : IAbility
    {
        public AbilityTypes Name { get ; set; }
        public int Rank { get; set; }

        public Ability(AbilityTypes ability, int ranks)
        {
            this.Name = ability;
            this.Rank = ranks;
        }
    }
}
