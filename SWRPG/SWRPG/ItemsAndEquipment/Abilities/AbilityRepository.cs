using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.Abilities
{
    public class AbilityRepository
    {
        public AbilityRepository()
        {

        }

        public Ability Retrieve(int abilityId)
        {
            var ability = new Ability();
            // code to retrieve ability

            // hard coded retrieve
            if(abilityId == 1)
            {
                ability = new Ability(1)
                {
                    AbilityName = "Strength",
                    Description = "How Strong You Are"
                };
            }

            return ability;
        }

        public bool Save()
        {
            // code to save
            return true;
        }
    }
}
