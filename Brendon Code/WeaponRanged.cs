using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAGettingForm
{
    public class WeaponRanged:Weapon
    {
        public WeaponRanged(string weapon_name, float weapon_damage):base(weapon_name, weapon_damage, WeaponType.Ranged)
        {

        }
    }
}
