using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApocalypseRPGv1
{
    public class Attribute
    {
        
        public AttributeType Type;
        public int Stat;
        public int Modifier;
        public int Duration;

        public Attribute(AttributeType type, int stat, int mod, int dur)
        {
           
            Type = type;
            Stat = stat;
            Modifier = mod;
            Duration = dur;
        }
    }
}
