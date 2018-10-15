using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class ItemQualitiesRepository
    {
        public ItemQualitiesRepository()
        {

        }

        public ItemQualities Retrieve(int itemQualityId)
        {
            var itemQualities = new ItemQualities(itemQualityId);

            // code to retrieve itemqualitied specified

            // temporary hard-code retrieve
            if(itemQualityId == 1)
            {
                itemQualities.Description = "Special";
                itemQualities.Passive = true;
                itemQualities.QualityName = "Speical Weapon";
            }
            else if(itemQualityId == 2)
            {
                itemQualities.Description = "Super Special";
                itemQualities.Passive = false;
                itemQualities.QualityName = "Super Speical Weapon";
            }

            return itemQualities;
        }

        public List<ItemQualities> Retrieve()
        {
            var itemQualities = new List<ItemQualities>();

            // code to retrieve item qualities

            // temporary hard-code retrieve
            itemQualities.Add(this.Retrieve(1));
            itemQualities.Add(this.Retrieve(2));

            return itemQualities;
        }

        public bool Save()
        {
            // code to save
            return true;
        }
    }
}
