using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Form1 : Form
    {

      
        private bool __quitBool = true;
        List<Label> labelsAdded = new List<Label>();
        List<TextBox> textboxsAdded = new List<TextBox>();
        private Point quitbutton;
        private Point loadbutton;
        private string characterName;
        public Form1()
        {
            InitializeComponent();
            //remember locations of when first loading form for load button and quit button.
            quitbutton = btnQuit.Location;
            loadbutton = btnLoadGame.Location;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblWelcomeScreen.Text = "Character Creation";
            btnQuit.Text = "Back";
            btnLoadGame.Hide();
            btnNewGame.Hide();   
            SetupNewGameLayout();
            __quitBool = !__quitBool;
        }

       

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
           
            lblWelcomeScreen.Text = "Characters:";
            btnNewGame.Hide();
            btnQuit.Text = "Back";
            SetupLoadCharacterInfo();
            if (__quitBool)
            {
                __quitBool = !__quitBool;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            __quitBool = !__quitBool;
            if (__quitBool)
            {
                DeleteAddedControls();
                lblWelcomeScreen.Text = "Welcome Screen";
                btnQuit.Location = quitbutton;
                btnLoadGame.Location = loadbutton;
                btnQuit.Text = "Quit";
                btnLoadGame.Show();
                btnNewGame.Show();

            }
            else
            {
                this.Close();
            }
        }


        private void SetupNewGameLayout()
        {
            Label lb = new Label();
            lb.Text = "Character Name:";
            lb.Width = 100;
            lb.Height = 20;
            lb.Location = new Point(50, 100);
            labelsAdded.Add(lb);
            this.Controls.Add(lb);
            lb = new Label();
            lb.Text = "Character Class:";
            lb.Width = 100;
            lb.Height = 20;
            lb.Location = new Point(50, 120);
            labelsAdded.Add(lb);
            this.Controls.Add(lb);

            TextBox tb = new TextBox();
            tb.Height = 30;
            tb.Width = 150;
            tb.Location = new Point(150, 100);
            textboxsAdded.Add(tb);
            this.Controls.Add(tb);

            tb = new TextBox();
            tb.Height = 30;
            tb.Width = 150;
            tb.Location = new Point(150, 120);
            textboxsAdded.Add(tb);
            this.Controls.Add(tb);

        }
        private void DeleteAddedControls()
        {
            foreach(Label l in labelsAdded)
            {
                this.Controls.Remove(l);
            }
            foreach(TextBox t in textboxsAdded)
            {
                this.Controls.Remove(t);
            }
        }
        private void SetupLoadCharacterInfo()
        {
            int locX = (this.Width/3)+20;
            int locY = this.Height-150;
            btnQuit.Location = new Point(locX, locY);
            btnLoadGame.Location = new Point(locX, this.Height - 100);
        }


    }
}
