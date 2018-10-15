using System;
using System.Collections.Generic;
using System.Text;

namespace Skills
{
    public interface ISkills
    {
        string Name { get; set; }
        Ability SkillAbility { get; set; };
    }
}
