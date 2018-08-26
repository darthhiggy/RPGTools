using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Skills
{
    interface ISkill
    {
        SkillType Type { get; set; }

        Abilities Ability { get; set; }

        bool ClassSkill { get; set; }

        int Ranks { get; set; }
    }
}
