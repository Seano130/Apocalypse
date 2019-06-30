using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace ApocalypseRPGv1
{
    public partial class FormMain : Form
    {
        protected const int WM_DOWN = 0x100;
        List<ILocateable> everything = new List<ILocateable>();
        Player jeff;
        protected Direction dir = Direction.None;

        protected Game g;

        public FormMain()
        {
            InitializeComponent();

            #region Old Dialogue
            //List<string> msgs = new List<string>();
            //msgs.Add("Welcome to Freddie's Store! What would you like to do?");
            //msgs.Add("Buy");
            //msgs.Add("Sell");
            //msgs.Add("Sword");
            //msgs.Add("Axe");
            //msgs.Add("Shield");
            //msgs.Add("Steal"); // 6
            //List<Choice> choices = new List<Choice>();
            //Choice ch = new Choice(0, 1, 0);
            //Choice ch2 = new Choice(0, 2, 0);
            //Choice ch3 = new Choice(1, 3, 1);
            //Choice ch4 = new Choice(1, 4, 1);
            //Choice ch5 = new Choice(1, 5, 1);
            //Choice ch6 = new Choice(2, 3, 1);
            //Choice ch7 = new Choice(2, 5, 1);
            //Choice ch8 = new Choice(0, 6, -1);
            //choices.Add(ch);
            //choices.Add(ch2);
            //choices.Add(ch3);
            //choices.Add(ch4);
            //choices.Add(ch5);
            //choices.Add(ch6);
            //choices.Add(ch7);
            //choices.Add(ch8);


            //Dialogue dlg = new Dialogue(choices, msgs);
            //dialogue.Add(NPCType.One, dlg);



            //Respond(0);
            #endregion

            

        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.UserPaint, true);

            UpdateStyles();

            g = new Game();
            g.Update += G_Update;
        }

        private void G_Update(List<ILocateable> everthing, Player jeff,DisplayText dt)
        {
            this.everything = everthing;
            this.jeff = jeff;
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics pic = e.Graphics;
            pic.Clear(Color.Black);

            if (g != null)
            {
                foreach (ILocateable loc in everything)
                {
                    pic.TranslateTransform((float)loc.Position.X, (float)loc.Position.Y);
                    pic.TranslateTransform(-loc.Width / 2, -loc.Height / 2);
                    pic.DrawImage(loc.Img, new Point());
                    pic.ResetTransform();
                }
                if (jeff != null)
                {
                    pic.TranslateTransform((float)jeff.Position.X, (float)jeff.Position.Y);
                    pic.TranslateTransform(-jeff.Width / 2, -jeff.Height / 2);
                    pic.DrawImage(jeff.Img, new Point());
                    pic.ResetTransform();
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(msg.Msg == WM_DOWN)
            {
                if(keyData == Keys.Up)
                {
                    dir = Direction.Up;
                }
                if(keyData == Keys.Down)
                {
                    dir = Direction.Down;
                }
                if(keyData == Keys.Left)
                {
                    dir = Direction.Left;
                }
                if(keyData == Keys.Right)
                {
                    dir = Direction.Right;
                }
            }
            g.InputFromUser(dir);// notify Game that new dir is chosen
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                dir = Direction.None;
            }
            g.InputFromUser(dir);// notify Game that new dir is chosen);
        }




        #region Respond function

        //protected void Respond(int from)
        //{

        //    tbMsgs.Text = ""; //clear out previous menu

        //    //assume we walked up on NPCType.One;
        //    Dialogue dlg = dialogue[NPCType.One];
        //    int oldState = dlg.State; // Where were we before this action

        //    List<Choice> allChoices = dlg.Choices;
        //    foreach(Choice ch in allChoices)
        //    {
        //        if(ch.From == oldState && ch.To == from)
        //        {
        //            Attitude += ch.AttAdjust;
        //        }
        //    }

        //    List<Choice> AllChoices = dlg.Choices;
        //    List<Choice> AllowedChoices = new List<Choice>();

        //    string fromMsg = dlg.Msgs[from]; // get starting msg
        //    tbMsgs.AppendText(fromMsg + "\r\n");

        //    foreach(Choice ch in AllChoices)
        //    {
        //        if(ch.From == from)
        //        {
        //            //Add only choices that start at state 0...
        //            AllowedChoices.Add(ch);
        //        }
        //    }

        //    foreach(Choice ch in AllowedChoices)
        //    {
        //        int to = ch.To; // get string index for "TO"
        //        string msg = dlg.Msgs[to];
        //        tbMsgs.AppendText(to + ") " + msg + "\r\n");
        //    }
        //    tbMsgs.AppendText("9) Exit \r\n");
        //    dlg.State = from;

        //}

        #endregion

        #region OnKeyUp
        //protected override void OnKeyUp(KeyEventArgs e)
        //{
        //    base.OnKeyUp(e);
        //    int sel = -1;
        //    switch(e.KeyCode)
        //    {
        //        case Keys.D0:
        //            sel = 0;
        //            break;
        //        case Keys.D1:
        //            sel = 1;
        //            break;
        //        case Keys.D2:
        //            sel = 2;
        //            break;
        //        case Keys.D3:
        //            sel = 3;
        //            break;
        //        case Keys.D4:
        //            sel = 4;
        //            break;
        //        case Keys.D5:
        //            sel = 5;
        //            break;
        //        case Keys.D6:
        //            sel = 6;
        //            break;
        //        case Keys.D7:
        //            sel = 7;
        //            break;
        //        case Keys.D8:
        //            sel = 8;
        //            break;
        //        case Keys.D9:
        //            sel = 9;
        //            break;

        //    }
        //    if (sel < 9)
        //    {
        //        Respond(sel);
        //        Text = Attitude.ToString();
        //    }
        //    else if(sel == 9)
        //    {
        //        Respond(0);
        //    }
        #endregion

    }

  

}
