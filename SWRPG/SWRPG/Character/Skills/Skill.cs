using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Abilities;

namespace Character.Skills
{
    public class Skill : ISkill
    {
        public SkillType Type { get; set; }
        public AbilityTypes Ability { get; set; }
        public bool ClassSkill { get; set; }
        public int Ranks { get; set; }
        public string Description { get; set; }

        public Skill(SkillType type, AbilityTypes ability, bool classSkill, int ranks, string description)
        {
            this.Type = type;
            this.Ability = ability;
            this.ClassSkill = classSkill;
            this.Ranks = ranks;
            this.Description = description;
        }

    }
}
