using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Abilities;

namespace Character.Skills
{
    interface ISkill
    {
        SkillType Type { get; set; }

        AbilityTypes Ability { get; set; }

        bool ClassSkill { get; set; }

        int Ranks { get; set; }

        string Description { get; set; }
    }
}
