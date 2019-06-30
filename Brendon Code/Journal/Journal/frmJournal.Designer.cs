namespace Journal
{
    partial class frmJournal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJournal = new System.Windows.Forms.Label();
            this.lblCurrentQuest = new System.Windows.Forms.Label();
            this.lblMainQuest = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJournal
            // 
            this.lblJournal.AutoSize = true;
            this.lblJournal.Location = new System.Drawing.Point(303, 48);
            this.lblJournal.Name = "lblJournal";
            this.lblJournal.Size = new System.Drawing.Size(41, 13);
            this.lblJournal.TabIndex = 0;
            this.lblJournal.Text = "Journal";
            // 
            // lblCurrentQuest
            // 
            this.lblCurrentQuest.AutoSize = true;
            this.lblCurrentQuest.Location = new System.Drawing.Point(78, 153);
            this.lblCurrentQuest.Name = "lblCurrentQuest";
            this.lblCurrentQuest.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentQuest.TabIndex = 1;
            this.lblCurrentQuest.Text = "Current Quest";
            // 
            // lblMainQuest
            // 
            this.lblMainQuest.AutoSize = true;
            this.lblMainQuest.Location = new System.Drawing.Point(531, 108);
            this.lblMainQuest.Name = "lblMainQuest";
            this.lblMainQuest.Size = new System.Drawing.Size(61, 13);
            this.lblMainQuest.TabIndex = 2;
            this.lblMainQuest.Text = "Main Quest";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(78, 312);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Quest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMainQuest);
            this.Controls.Add(this.lblCurrentQuest);
            this.Controls.Add(this.lblJournal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJournal;
        private System.Windows.Forms.Label lblCurrentQuest;
        private System.Windows.Forms.Label lblMainQuest;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

