using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Abilities;
using Character.Talents;

namespace Species
{
    public class Species : ISpecies
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpecialDescription { get; set; }
        public string Physiology { get; set; }
        public string Society { get; set; }
        public string HomeWorld { get; set; }
        public string Language { get; set; }
        public string LifeOnTheFringe { get; set; }
        public AbilitySet SpeciesAbility { get; set; }
        public int WoundThresholdBonus { get; set; }
        public Ability WoundThresholdAbilityBonus { get; set; }
        public int StrainThresholdBonus { get; set; }
        public Ability StrainThresholdAbilityBonus { get; set; }
        public int StartingExp { get; set; }
        public List<string> SpecialAbilities { get; set; }
        public List<Talent> SpeciesTalent { get; set; }

        public int GetStartingWoundThreshhold() => WoundThresholdAbilityBonus.Rank + WoundThresholdBonus;

        public int GetStartingStrainThreshold() => StrainThresholdAbilityBonus.Rank + StrainThresholdBonus;
        
    }
}
