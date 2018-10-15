using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class Armor : IEquipment
    {
        public int ArmorId { get; private set; }
        public string Name { get; set; }
        public int Encumbrance { get; set; }
        public int Rarity { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Defense { get; set; }
        public int Soak { get; set; }

        public Armor()
            : this(0)
        {

        }

        public Armor(int armorId)
        {
            this.ArmorId = armorId;
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;
            else
                return true;
        }
    }
}
