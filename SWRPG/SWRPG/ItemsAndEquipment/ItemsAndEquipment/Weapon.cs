using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWRPG.Buisness.Abilities;
using SWRPG.Buisness.Combat;
using SWRPG.Buisness.Skills;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class Weapon : IEquipment
    {
        public int EquipmentId { get; private set; }
        public string Name { get; set; }
        public int Encumbrance { get; set; }
        public int Rarity { get; set; }
        public string Description { get; set; }
        public CombatSkill Skill { get; set; }
        public int BaseDamage { get; set; }
        public int Range { get; set; }
        public int CriticalRating { get; set; }
        public int HardPoints { get; set; }
        public int Price { get; set; }
        public List<ItemQualities> Special { get; set; }

        public Weapon()
            : this(0)
        {

        }

        public Weapon(int equipmentId)
        {
            this.EquipmentId = equipmentId;
            this.Skill = new CombatSkill();
            Special = new List<ItemQualities>();
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;
            else if (Encumbrance < 0)
                return false;
            else if (Skill == null)
                return false;
            else if (BaseDamage < 0)
                return false;
            else if (Range < 0)
                return false;
            else if (CriticalRating < 0)
                return false;
            else if (Price < 0)
                return false;
            else 
                return true;
        }
    }
}
