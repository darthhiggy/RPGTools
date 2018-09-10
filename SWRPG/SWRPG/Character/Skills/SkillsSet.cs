using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Skills
{
    public class SkillsSet
    {
        public List<Skill> SkillSet { get; set; }

        public SkillsSet(List<Skill> skillSet) => SkillSet = skillSet;

        private List<Skill> GetSkillType(SkillType type) => (List<Skill>)SkillSet.Where(s => s.Type == type);

        public List<Skill> GetGerneralSkills() => GetSkillType(SkillType.General);

        public List<Skill> GetCombatSkills() => GetSkillType(SkillType.Combat);

        public List<Skill> GetKnowledgeSkills() => GetSkillType(SkillType.Knowledge);

        public void AddSkillPoints(string skillName, int ranks)
        {
            var item = SkillSet.FirstOrDefault(s => s.Type.Equals(skillName));
            item.Ranks += ranks;
        }

        public void AddSkillPoints(Dictionary<string, int>SkillsAndRanks)
        {
            foreach(var skill in SkillsAndRanks.Keys)
            {
                AddSkillPoints(skill, SkillsAndRanks[skill]);
            }
        }
    }
}
