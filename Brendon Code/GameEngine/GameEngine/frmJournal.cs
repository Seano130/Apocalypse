using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//https://colinmackay.scot/2005/04/22/passing-values-between-forms-in-net/

namespace GameEngine
{
    public partial class frmJournal : Form
	{
		

		protected List<Quest> quests = new List<Quest>();
		
		

		public frmJournal(Quest quest)
        {
            InitializeComponent();
            CreateInfo(quest);
            DisplayInfo();
			this.FormClosing += FrmJournal_FormClosing;
			
        }

		private void FrmJournal_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageBox.Show("Closed Quests");
		}

		protected void DisplayInfo()
        {
            lblStatus.Text = "";
			foreach(Quest n in quests)
			{
				lblCurrentQuest.Text = n.GetQuestName;
			}
            //lblCurrentQuest.Text = quests[1].GetQuestName;
            foreach (Quest q in quests)
            {
                lblStatus.Text += "\n"+q.GetQuestDescription;
            }
        }
        protected void CreateInfo(Quest quest)
        {
           
			quests.Add(quest);
           
        }
		
    }
}
