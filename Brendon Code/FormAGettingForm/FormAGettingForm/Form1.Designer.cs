namespace FormAGettingForm
{
    partial class Form1
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
            this.btnLoadChara = new System.Windows.Forms.Button();
            this.lbSavedFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLoadChara
            // 
            this.btnLoadChara.Location = new System.Drawing.Point(310, 320);
            this.btnLoadChara.Name = "btnLoadChara";
            this.btnLoadChara.Size = new System.Drawing.Size(147, 23);
            this.btnLoadChara.TabIndex = 0;
            this.btnLoadChara.Text = "FindSaveFile";
            this.btnLoadChara.UseVisualStyleBackColor = true;
            this.btnLoadChara.Click += new System.EventHandler(this.btnLoadChara_Click);
            // 
            // lbSavedFiles
            // 
            this.lbSavedFiles.FormattingEnabled = true;
            this.lbSavedFiles.Location = new System.Drawing.Point(12, 133);
            this.lbSavedFiles.Name = "lbSavedFiles";
            this.lbSavedFiles.Size = new System.Drawing.Size(776, 147);
            this.lbSavedFiles.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSavedFiles);
            this.Controls.Add(this.btnLoadChara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadChara;
        private System.Windows.Forms.ListBox lbSavedFiles;
    }
}

