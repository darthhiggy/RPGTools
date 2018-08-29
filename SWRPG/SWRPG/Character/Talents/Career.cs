using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Skills;

namespace Character.Talents
{
    public class Career : ICareer
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public List<string> Storeis { get; set; }
        public List<Skill> ClassSkills { get; set; }
        public List<SkillTree> Specializations { get; set; }
    }
}
