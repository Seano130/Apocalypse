using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamge) : base(id, name, namePlural)
        {

            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamge;

        }
    }
}
