using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    public partial class frmJournal : Form
    {

        protected List<Quest> quests = new List<Quest>();

        public frmJournal()
        {
            InitializeComponent();
            CreateInfo();
            DisplayInfo();
   
        }
        protected void DisplayInfo()
        {
            lblStatus.Text = "";
            lblCurrentQuest.Text = quests[1].GetQuestName;
            foreach (Quest q in quests)
            {
                lblStatus.Text += "\n"+q.GetQuestDescription;
            }
        }
        protected void CreateInfo()
        {
            for (int i = 0; i < 10; i++)
            {
                Quest q = new Quest("Main Quest", "This is the main quest discription", false);
                quests.Add(q);
            }
        }

    }
}
