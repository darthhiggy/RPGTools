using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.Abilities
{
    public class Ability
    {
        public int AbilityId { get; private set; }
        public string AbilityName { get; set; }
        public string Description { get; set; }

        public Ability()
            : this(0)
        {

        }

        public Ability(int abilityId)
        {
            this.AbilityId = abilityId;
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(AbilityName))
                return false;
            else
                return true;
        }
    }
}
