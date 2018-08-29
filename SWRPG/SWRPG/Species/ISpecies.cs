using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Abilities;
using Character.Talents;

namespace Species
{
    public interface ISpecies
    {
        string Name { get; set; }

        string Description { get; set; }

        string SpecialDescription { get; set; }

        string Physiology { get; set; }

        string Society { get; set; }

        string HomeWorld { get; set; }

        string Language { get; set; }

        string LifeOnTheFringe { get; set; }

        AbilitySet SpeciesAbility { get; set; }

        int GetStartingWoundThreshhold();

        int WoundThresholdBonus { get; set; }

        Ability WoundThresholdAbilityBonus { get; set; }

        int GetStartingStrainThreshold();

        int StrainThresholdBonus { get; set; }

        Ability StrainThresholdAbilityBonus { get; set; }

        int StartingExp { get; set; }

        List<string> SpecialAbilities { get; set; }

        List<Talent> SpeciesTalent { get; set; }
    }
}
