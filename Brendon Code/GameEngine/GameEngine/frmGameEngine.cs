using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
	public partial class Form1 : Form
	{
		List<Mob> mobs = new List<Mob>();
		Mob mainCharacter;
		Timer tmr;
		bool isPaused = false;
		#region duel key press
		bool keyW = false;  //south west
		bool keyA = false;  //south east
		bool keyS = false; // north west
		bool keyD  = false; //north east
		bool multidirection = false;
		#endregion
		bool flag = false;

		


		public Form1()
		{
			InitializeComponent();
			Bitmap bt = new Bitmap(GameEngine.Properties.Resources.FriendlyNpc_10000);

			//Image im = GameEngine.Properties.Resources.FriendlyNpc_10000;

			mainCharacter = new Mob(100, new Point(this.Width / 2, this.Height / 2), GameEngine.Properties.Resources.MainCharacter0000);
			mobs.Add(mainCharacter);
			DoubleBuffered = true;
			tmr = new Timer();
			tmr.Tick += Tmr_Tick;
			tmr.Interval = 16;
			tmr.Start();

			 //TODO TEST
			


		}

		private void Tmr_Tick(object sender, EventArgs e)
		{
			
			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{	
			foreach(Mob m in mobs)
			{
				e.Graphics.DrawImage(m.MobImage, m.Location);
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			int WalkSpeed = 10;

			
			if (keyW)
			{
				Point p = new Point();
				p.X = mainCharacter.Location.X;
				p.Y = mainCharacter.Location.Y - WalkSpeed;
				mainCharacter.Location = p;

			}
			if (keyA)
			{
				Point p = new Point();
				p.X = mainCharacter.Location.X - WalkSpeed;
				p.Y = mainCharacter.Location.Y;
				mainCharacter.Location = p;
			}
			if (keyS)
			{
				Point p = new Point();
				p.X = mainCharacter.Location.X;
				p.Y = mainCharacter.Location.Y + WalkSpeed;
				mainCharacter.Location = p;
			}
			if (keyD)
			{
				Point p = new Point();
				p.X = mainCharacter.Location.X + WalkSpeed;
				p.Y = mainCharacter.Location.Y;
				mainCharacter.Location = p;
			}
			if (e.KeyCode == Keys.W)
			{
				keyW = true;
			}
			if (e.KeyCode == Keys.S)
			{
				keyS = true;
			}
			if (e.KeyCode == Keys.A)
			{
				keyA = true;
			}
			if (e.KeyCode == Keys.D)
			{
				keyD = true;
			}
		
			


			/*
			 W
			 Point p = new Point();
				p.X = mainCharacter.Location.X;
				p.Y = mainCharacter.Location.Y - WalkSpeed;
				mainCharacter.Location = p;
			 A
			 Point p = new Point();
				p.X = mainCharacter.Location.X - WalkSpeed;
				p.Y = mainCharacter.Location.Y;
				mainCharacter.Location = p;
			 S
			 Point p = new Point();
				p.X = mainCharacter.Location.X;
				p.Y = mainCharacter.Location.Y + WalkSpeed;
				mainCharacter.Location = p;
			 D
			 Point p = new Point();
				p.X = mainCharacter.Location.X + WalkSpeed;
				p.Y = mainCharacter.Location.Y;
				mainCharacter.Location = p;
			 */


		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W)
			{
				keyW = false;
			}
			if(e.KeyCode == Keys.A)
			{
				keyA = false;
			}
			if (e.KeyCode == Keys.S)
			{
				keyS = false;
			}
			if (e.KeyCode == Keys.D)
			{
				keyD = false;
			}

			if (e.KeyCode == Keys.J)
			{
				tmr.Stop();
				//open GameEngine	
				Quest q = new Quest("Main Quest", "This is the main quest discription", false);
				frmJournal fm = new frmJournal(q);
				fm.Show();
				isPaused = true;
			}
		}
	}
}
