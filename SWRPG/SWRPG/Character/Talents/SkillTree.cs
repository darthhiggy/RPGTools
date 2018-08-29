using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Skills;

namespace Character.Talents
{
    public class SkillTree : ISkillTree
    {
        public string Name { get; set; }

        public List<Talent> TalentList { get ; set; }
        public string Description { get; set; }
        public List<Skill> CareerSkills { get; set; }
    }
}
