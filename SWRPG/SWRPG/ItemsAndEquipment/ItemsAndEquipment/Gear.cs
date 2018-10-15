using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class Gear : IEquipment
    {
        public int GearId { get; private set; }
        public string Name { get; set; }
        public int Encumbrance { get; set; }
        public int Rarity { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Gear()
            : this(0)
        {

        }

        public Gear(int gearId)
        {
            this.GearId = gearId;
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
