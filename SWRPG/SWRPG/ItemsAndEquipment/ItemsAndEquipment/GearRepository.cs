using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class GearRepository
    {
        public GearRepository()
        {

        }

        public Gear Retrieve(int gearId)
        {
            var gear = new Gear(gearId);

            // code to retrieve the defined customer

            // temporary hard coded values to return 
            if(gearId == 1)
            {
                gear.Description = "See far away";
                gear.Encumbrance = 1;
                gear.Name = "Macrobinoculars";
                gear.Price = 100;
                gear.Rarity = 1;
            }

            return gear;
        }

        public bool Save()
        {
            // code to save gear
            return true;
        }
    }
}
