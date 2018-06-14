using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {

        public int Gold { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }


        public Player(int currentHP, int maxHP, int gold, int xp, int level ) : base(currentHP, maxHP)
        {
            Gold = gold;
            XP = xp;
            Level = level;


        }


    }
}
