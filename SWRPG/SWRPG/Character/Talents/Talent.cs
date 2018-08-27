using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Talents
{
    public class Talent : ITalent
    {
        public string Name { get; set; }
        public Activations Activation { get; set; }
        public bool Ranked { get; set; }
        public List<SkillTree> SkillTrees {get; set; }
        public string Description { get; set; }

    }
}
