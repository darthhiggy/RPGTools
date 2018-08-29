using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Skills;

namespace Character.Talents
{
    interface ICareer
    {
        string Name { get; set; }

        string Role { get; set; }

        List<string> Storeis { get; set; }

        List<Skill> ClassSkills { get; set; }

        List<SkillTree> Specializations { get; set; }
    }
}
