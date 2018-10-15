using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWRPG.Buisness.Skills;

namespace SWRPG.Buisness.ItemsAndEquipment
{
    public class WeaponRepository
    {
        public WeaponRepository()
        {
            combatSkillRepository = new CombatSkillRepository();
            itemQualitiesRepository = new ItemQualitiesRepository();
        }

        public CombatSkillRepository combatSkillRepository { get; set; }
        public ItemQualitiesRepository itemQualitiesRepository { get; set; }

        public Weapon Retrieve(int weaponId)
        {
            var weapon = new Weapon(weaponId);

            // code to retrieve the defined weapon

            // temporary hard coded values to return
            if(weaponId == 1)
            {
                weapon.Name = "Baster Pistol";
                weapon.BaseDamage = 3;
                weapon.CriticalRating = 4;
                weapon.Description = "Fires blaster bolts";
                weapon.Encumbrance = 2;
                weapon.HardPoints = 2;
                weapon.Price = 400;
                weapon.Range = 2;
                weapon.Rarity = 3;
                weapon.Skill = combatSkillRepository.Retrieve(1);
                weapon.Special = itemQualitiesRepository.Retrieve();
            }

            return weapon;
        }

        public bool Save()
        {
            // code to save weapon
            return true;
        }
    }
}
