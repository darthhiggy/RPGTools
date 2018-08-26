using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Skills
{
    public class Athletics : ISkill
    {
        public SkillType Type { get => Type; set => Type = SkillType.General; }
        public Abilities Ability { get => Ability; set => Ability = Abilities.Brawn; }
        public bool ClassSkill { get; set; }
        public int Ranks { get; set; }

        public Athletics(bool classSkill, int ranks)
        {
            ClassSkill = classSkill;
            Ranks = ranks;
        }
    }
}
