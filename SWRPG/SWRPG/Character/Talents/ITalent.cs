using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Talents
{
    public interface ITalent
    {
        string Name {get; set;}

        Activations Activation { get; set; }

        bool Ranked { get; set; }

        List<SkillTree> SkillTrees { get; set; }

        string Description { get; set; }


    }
}
