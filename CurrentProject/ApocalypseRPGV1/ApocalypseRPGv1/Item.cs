using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // needed for Image class
using Utilities;

namespace ApocalypseRPGv1
{
    public class Item : ILocateable, IProfession
    {
        public string Name { get ; set ; }
        public Image Img { get ; set ; }
        public Vector Position { get ; set ; }
        public double Angle { get ; set ; }

        public int Width => throw new NotImplementedException();

        public int Height => throw new NotImplementedException();

        public Vector Vel { get; set; }
        public int MaxSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Consumable;
        public int Modifier;
        public int Damage;
        public AttributeType Type;
        public int Duration;

        public Item(string name, Vector pos, Image img, bool cons, int mod, int dam, AttributeType type, int dur)
        {
            Name = name;
            Img = img;
            Position = pos;

            Consumable = cons;
            Modifier = mod;
            Damage = dam;
            Type = type;
            Duration = dur;
        }

        public void Move(double time)
        {
            throw new NotImplementedException();
        }
    }
}
