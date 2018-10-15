using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class ArmorRepository
    {
        public ArmorRepository()
        {

        }

        public Armor Retrieve(int armorId)
        {
            var armor = new Armor(armorId);

            // code that retrieves the defined customer

            // temporary hard coded values to return 
            if(armorId == 1)
            {
                armor.Defense = 1;
                armor.Description = "Protects the wearer";
                armor.Encumbrance = 2;
                armor.Name = "Heavy Clothing";
                armor.Price = 200;
                armor.Rarity = 1;
                armor.Soak = 1;
            }

            return armor;
        }

        public bool Save()
        {
            // code to save Armor
            return true;
        }
    }
}
