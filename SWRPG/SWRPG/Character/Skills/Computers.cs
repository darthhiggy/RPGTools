using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Skills
{
    public class Computers : ISkill
    {
        public SkillType Type { get => Type; set => throw new NotImplementedException(); }
        public Abilities Ability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ClassSkill { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ranks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
