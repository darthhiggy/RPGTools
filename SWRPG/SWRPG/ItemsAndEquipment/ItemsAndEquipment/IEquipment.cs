using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public interface IEquipment
    {
        string Name { get; set; }
        int Encumbrance { get; set; }
        int Rarity { get; set; }
        string Description { get; set; }
        int Price { get; set; }
    }
}
