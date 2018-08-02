using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsAndEquipment.ItemTypes
{
    public class Armor : Item
    {
        public string Type { get; set; }
        
        public int Soak { get; set;  }

        public int Defense { get; set; }

        public int HardPoints { get; set; }

        public bool IsRestricted { get; set; }

        public string Qualities { get; set; }
    }
}
