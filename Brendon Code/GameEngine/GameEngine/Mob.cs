using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GameEngine
{
	public class Mob
	{
		//What will mob need
		//what is mob
		int hp;
		int stamina;
		Point location;
		Image im;



		public int HP { get{ return this.hp; } }
		public Point Location
		{
			get
			{
					return this.location;
			}
			set
			{
				location = value;
			}
		}
		public Image MobImage { get { return this.im; } }

		public Mob()
		{

		}
		public Mob(int hp, Point loc, Image im)
		{
			this.hp = hp;
			this.location = loc;
			this.im = im;
		}

	}
}
