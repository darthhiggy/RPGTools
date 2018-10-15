using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWRPG.Buisness.Abilities;

namespace SWRPG.Buisness.Skills
{
    public class CombatSkill : ISkills
    {
        public int CombatSkillId { get; private set; }
        public string SkillName { get; set; }
        public Ability SkillAbility { get; set; }
        public string Description { get; set; }

        public CombatSkill()
            : this(0)
        {

        }

        public CombatSkill(int combatSkillId)
        {
            this.CombatSkillId = combatSkillId;
            SkillAbility = new Ability();
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(SkillName))
                return false;
            else
                return true;
        }
    }
}
