using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Skills
{
    public class Astrogation : ISkill
    {
        public SkillType Type { get => Type; set => Type = SkillType.General; }
        public Abilities Ability { get => Ability; set => Ability = Abilities.Intellect; }
        public bool ClassSkill { get; set; }
        public int Ranks { get; set; }

        public Astrogation(bool classSkill, int ranks)
        {
            ClassSkill = classSkill;
            Ranks = ranks;
        }

    }
}
