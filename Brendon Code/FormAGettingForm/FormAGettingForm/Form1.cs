using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FormAGettingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadChara_Click(object sender, EventArgs e)
        {
            //FileInfo fi = new FileInfo(Application.StartupPath);
            DirectoryInfo fiParent = Directory.GetParent(Application.StartupPath);
            FileInfo[] files = fiParent.GetFiles();
            foreach(FileInfo f in files)
            {
                //if condition to grab the save file.
                if(f.Extension == ".resx")
                {
                    lbSavedFiles.Items.Add(f.FullName);
                }
                
            }
            //lbSavedFiles.Items.Add();


           
        }
    }
}
