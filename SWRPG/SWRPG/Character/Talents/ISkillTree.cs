using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Skills;

namespace Character.Talents
{
    public interface ISkillTree
    {
        string Name { get; set; }

        string Description { get; set; }

        List<Skill> CareerSkills { get; set; }

        List<Talent> TalentList { get; set; }


    }
}
