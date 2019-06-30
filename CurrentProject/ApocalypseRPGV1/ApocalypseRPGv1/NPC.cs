using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace ApocalypseRPGv1
{
    public class NPC : ILocateable, IProfession, ISpeakable
    {
        protected Animation ani;

        public string Name { get ; set ; }

        public Image Img
{
            get
            {
                return ani.Frame;
            }
            set
            {

            }
        }
        public Vector Position { get ; set ; }

        public double Angle
        {
            get
            {
                return Vel.Angle;
            }
            set
            {

            }

        }

        public int Width
        {
            get
            {
                return ani.Width;
            }
        }

        public int Height
        {
            get
            {
                return ani.Height;
            }
        }

        public int MaxSpeed { get ; set ; }
        public Vector Vel { get ; set ; }
        public Dialogue Dialogue { get; set; }
        public List<Choice> ChoicesRemembered { get; set; }



        public NPC(string nm, Animation ani, Vector pos, Vector vel, Dialogue dlg, int maxSpd)
        {
            Name = nm;
            this.ani = ani;
            Position = pos;
            Vel = vel;
            Dialogue = dlg; ;
            MaxSpeed = maxSpd;
           // ChoicesRemembered = new List<Choice>(); // Brand new blank history on birth
        }

    }
        
}
