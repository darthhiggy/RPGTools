using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class ItemQualities
    {
        public ItemQualities()
        {

        }

        public ItemQualities(int itemQualityId)
        {
            this.ItemQualityId = itemQualityId;
        }

        public int ItemQualityId { get; private set; }
        public string QualityName { get; set; }
        public bool Passive { get; set; }
        public string Description { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(QualityName))
                return false;

            return true;
        }
    }
}
