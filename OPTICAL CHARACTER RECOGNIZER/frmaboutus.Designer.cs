namespace OPTICAL_CHARACTER_RECOGNIZER
{
    partial class frmaboutus
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaboutus));
               this.panel1 = new System.Windows.Forms.Panel();
               this.aboutcancel = new System.Windows.Forms.Button();
               this.panel5 = new System.Windows.Forms.Panel();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.panel1.SuspendLayout();
               this.panel5.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel1.Controls.Add(this.aboutcancel);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(425, 32);
               this.panel1.TabIndex = 0;
               // 
               // aboutcancel
               // 
               this.aboutcancel.BackColor = System.Drawing.Color.Transparent;
               this.aboutcancel.ForeColor = System.Drawing.Color.Brown;
               this.aboutcancel.Location = new System.Drawing.Point(360, 1);
               this.aboutcancel.Name = "aboutcancel";
               this.aboutcancel.Size = new System.Drawing.Size(51, 23);
               this.aboutcancel.TabIndex = 0;
               this.aboutcancel.Text = "&Close";
               this.aboutcancel.UseVisualStyleBackColor = false;
               this.aboutcancel.Click += new System.EventHandler(this.aboutcancel_Click);
               // 
               // panel5
               // 
               this.panel5.BackColor = System.Drawing.Color.Transparent;
               this.panel5.Controls.Add(this.label5);
               this.panel5.Controls.Add(this.label4);
               this.panel5.Controls.Add(this.label3);
               this.panel5.Location = new System.Drawing.Point(83, 32);
               this.panel5.Name = "panel5";
               this.panel5.Size = new System.Drawing.Size(255, 173);
               this.panel5.TabIndex = 5;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(78, 85);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(79, 39);
               this.label5.TabIndex = 2;
               this.label5.Text = "\r\n    Daniel\r\n    0717005802";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(15, 59);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(187, 26);
               this.label4.TabIndex = 1;
               this.label4.Text = "(C) 2015-2016 . DIGITAL DYNAMIKS \r\n                           TECHNOSURF";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(49, 9);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(88, 26);
               this.label3.TabIndex = 0;
               this.label3.Text = "S version 1.00\r\n    2017 Release.";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Location = new System.Drawing.Point(98, 220);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(234, 91);
               this.label2.TabIndex = 6;
               this.label2.Text = resources.GetString("label2.Text");
               // 
               // frmaboutus
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonFace;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.ClientSize = new System.Drawing.Size(425, 366);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.panel5);
               this.Controls.Add(this.panel1);
               this.DoubleBuffered = true;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "frmaboutus";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Aboutus";
               this.panel1.ResumeLayout(false);
               this.panel5.ResumeLayout(false);
               this.panel5.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button aboutcancel;
        private System.Windows.Forms.Label label2;
    }
}