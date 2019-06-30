using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Utilities;

namespace ApocalypseRPGv1
{
    public class Character
    {
        public Vector Pos, Vel, Goal;
        public float Angle;
        public Image Img;
        protected List<Character> contacts = new List<Character>();

        public Character(Vector pos, Vector vel, Vector goal, float angle, Image img)
        {
            Pos = pos;
            Vel = vel;
            Goal = goal;
            Angle = angle;
            Img = img;
        }


       

    }
}
