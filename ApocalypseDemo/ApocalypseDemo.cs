using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace ApocalypseDemo
{
    public partial class ApocalypseDemo : Form
    {
        private Player _player;
     
        public ApocalypseDemo()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";

            _player = new Player(10, 10, 20, 0, 1);


            lblHP.Text = _player.CurrentHP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblXP.Text = _player.XP.ToString();
            lblLevel.Text = _player.Level.ToString();

            

        }

        
    }
}
