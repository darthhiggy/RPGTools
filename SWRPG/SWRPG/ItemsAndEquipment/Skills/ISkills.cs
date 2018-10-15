using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWRPG.Buisness.Abilities;

namespace SWRPG.Buisness.Skills
{
    public interface ISkills
    {
        string SkillName { get; set; }
        Ability SkillAbility { get; set; }
        string Description { get; set; }
    }
}
