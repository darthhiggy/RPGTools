using ItemsAndEquipment.ItemTypes;
using System.Collections.Generic;

namespace ItemsAndEquipment.Repository
{
    public interface IArmorRepository : IItemsRepository
    {
        IEnumerable<Armor> GetArmor();

        Armor GetArmor(string name);

        void AddArmor(Armor newArmor);

        void UpdateArmor(Armor ArmorUpdate, string name);

        void DeleteArmor(string name);

        void UpdateArmors(IEnumerable<Armor> updatedArmors);
    }
}
