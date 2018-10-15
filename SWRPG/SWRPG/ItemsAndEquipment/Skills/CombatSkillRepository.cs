using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWRPG.Buisness.Abilities;

namespace SWRPG.Buisness.Skills
{
    public class CombatSkillRepository
    {
        public CombatSkillRepository()
        {
            abilityRepository = new AbilityRepository();
        }

        public AbilityRepository abilityRepository { get; set; }

        public CombatSkill Retrieve(int combatSkillId)
        {
            var combatSkill = new CombatSkill();

            // code to retrieve combatskill

            // hard coded retrieve 
            if(combatSkillId == 1)
            {
                combatSkill = new CombatSkill()
                {
                    SkillName = "Melee",
                    SkillAbility = abilityRepository.Retrieve(1),
                    Description = "Hit people good"
                };
            }

            return combatSkill;

        }
    }
}
