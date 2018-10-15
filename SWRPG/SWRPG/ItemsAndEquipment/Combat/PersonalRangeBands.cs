using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRPG.Buisness.Combat
{
    public class PersonalRangeBands
    {
        public int PersonalRangeBandsId { get; private set; }
        public RangeBands Range { get; set; }
        public string Description { get; set; }

        public PersonalRangeBands()
            : this(0)
        {

        }

        public PersonalRangeBands(int personalrangeBandsId)
        {
            this.PersonalRangeBandsId = personalrangeBandsId;
        }

        public bool Validate()
        {
            if (Range == 0)
                return false;
            else
                return false;
        }
    }
}
