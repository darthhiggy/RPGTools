using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Abilities
{
    public class AbilitySet
    {
        List<Ability> AbilityList { get; set; }

        public AbilitySet(int brawn, int agility, int intellect, int cunning, int willpower, int prescence)
        {
            AbilityList.Add(new Ability(AbilityTypes.Brawn, brawn));
            AbilityList.Add(new Ability(AbilityTypes.Agility, agility));
            AbilityList.Add(new Ability(AbilityTypes.Intellect, intellect));
            AbilityList.Add(new Ability(AbilityTypes.Cunning, cunning));
            AbilityList.Add(new Ability(AbilityTypes.Willpower, willpower));
            AbilityList.Add(new Ability(AbilityTypes.Prescence, prescence));
        }

        public Ability GetAbility(AbilityTypes abl) => AbilityList.FirstOrDefault(a => a.Name == abl);

        public void AddRank(AbilityTypes abl, int ranks) => AbilityList.FirstOrDefault(a => a.Name == abl).Rank += ranks;

        public void AddRanks(Dictionary<AbilityTypes, int> abls)
        {
            foreach(var abl in abls.Keys)
            {
                AddRank(abl, abls[abl]);
            }
        }


    }
}
