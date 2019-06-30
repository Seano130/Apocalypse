using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAGettingForm
{
    public class Weapon
    {
        protected string _weaponName;
        protected float _weaponDamage;
        protected WeaponType _weaponType;

        //access to what the weapons are and damage
        public string GetWeaponName { get{ return _weaponName; } }
        public float GetWeaponDamage { get { return _weaponDamage; } }

        public Weapon(string weapon_name,float weapon_damage, WeaponType weapon_type)
        {
            _weaponName = weapon_name;
            _weaponDamage = weapon_damage;
            _weaponType = weapon_type;
        }
    }
}
