using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Skills
{
    public class Coercion : ISkill
    {
        public SkillType Type { get => Type; set => Type = SkillType.General; }
        public Abilities Ability { get => Ability; set => Ability = Abilities.Prescence; }
        public bool ClassSkill { get; set; }
        public int Ranks { get; set; }

        public Coercion(bool classSkill, int ranks)
        {
            ClassSkill = classSkill;
            Ranks = ranks;
        }
    }
}
