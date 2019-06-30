using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    // Input/Output

namespace Apocalypse
{
    public partial class FrmMain : Form
    {
        protected int Attitude = 0;
        protected string dialogFilename;
        protected string dialogOrderFilename;
        protected Dialog dlg;// placeholder to contain a Dialog object for a vendor that is yet to be defined
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tbFilename.Text = ofd.FileName;// put chosen filename in TB for user to see
                dialogFilename = ofd.FileName;// store their chosen filename as variable
                FileInfo fi = new FileInfo(dialogFilename);// create C# object for this file
                int lenWhole = fi.Name.Length;
                int lenExt = fi.Extension.Length;
                string fileFront = fi.Name.Substring(0, lenWhole - lenExt) + "Order";
                string fileExt = fi.Extension;
                dialogOrderFilename = fileFront + fileExt;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tbFilename.Text.Length > 0)
            {
                List<string> msgs = new List<string>();
                using (StreamReader sr = new StreamReader(dialogFilename))// use path that user had already chosen before
                {
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();// read 1 line at a time
                        //string[] pair = line.Split(':');
                        //string varName = pair[0];
                        //string varValue = pair[1];
                        tbFile.AppendText(line + Environment.NewLine);
                        msgs.Add(line);// add this dialog string one at a time into the Collection
                    }
                }

                List<Choice> choices = new List<Choice>();
                using (StreamReader sr = new StreamReader(dialogOrderFilename))
                {
                    while(sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();// read in 1 line at a time
                        string[] trio = line.Split(',');// split 3 ints by the ,
                        int from = Convert.ToInt32(trio[0]);
                        int to = Convert.ToInt32(trio[1]);
                        int att = Convert.ToInt32(trio[2]);
                        Choice ch = new Choice(from, to, att);
                        choices.Add(ch);// add this current choice to the List<>
                    }
                }
                // now we have all info for this vendor's dialog/plot, so create his Dialog Object...
                dlg = new Dialog(choices, msgs);
                btnStart.Visible = true;
                tbDialog.Visible = true;
            }
        }

        protected void Respond(int from)
        {

            tbDialog.Text = "";// clear out previous menu
            // assume we walked up on NPCType.One:
            int oldState = dlg.State;// where were we before this action

            List<Choice> allChoices = dlg.Choices;
            foreach (Choice ch in allChoices)
            {
                if (ch.From == oldState && ch.To == from)
                {
                    Attitude += ch.AttAdjust;
                }
            }


            List<Choice> allowedChoices = new List<Choice>();
            string fromMsg = dlg.Msgs[from];// get starting msg
            tbDialog.AppendText(fromMsg + "\r\n");
            foreach (Choice ch in allChoices)
            {
                if (ch.From == from)
                {   // add only choices that start at state 0...
                    allowedChoices.Add(ch);
                }
            }

            foreach (Choice ch in allowedChoices)
            {
                int to = ch.To;// get string index for "TO"
                string msg = dlg.Msgs[to];
                tbDialog.AppendText(to + ") " + msg + "\r\n");
            }
            tbDialog.AppendText("9) Exit\r\n");
            dlg.State = from;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Respond(0);// begin the dialog at the 0th item
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            int sel = -1;
            switch (e.KeyCode)
            {
                case Keys.D0:
                    sel = 0;
                    break;
                case Keys.D1:
                    sel = 1;
                    break;
                case Keys.D2:
                    sel = 2;
                    break;
                case Keys.D3:
                    sel = 3;
                    break;
                case Keys.D4:
                    sel = 4;
                    break;
                case Keys.D5:
                    sel = 5;
                    break;
                case Keys.D6:
                    sel = 6;
                    break;
                case Keys.D7:
                    sel = 7;
                    break;
                case Keys.D8:
                    sel = 8;
                    break;
                case Keys.D9:
                    sel = 9;
                    break;
            }
            if (sel >= 0 && sel < 9)
            {
                Respond(sel);
                Text = Attitude.ToString();
            }
            else if (sel == 9)
            {
                tbDialog.Text = "";// clear out dialog and enter Exploratory mode
                Text = "Explore mode";
            }

        }
    }
}
