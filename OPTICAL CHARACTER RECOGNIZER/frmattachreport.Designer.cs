namespace OPTICAL_CHARACTER_RECOGNIZER
{
     partial class frmattachreport
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmattachreport));
               this.panel1 = new System.Windows.Forms.Panel();
               this.userid = new System.Windows.Forms.Label();
               this.lbluser = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.label13 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
               this.frmattachmentreport1 = new OPTICAL_CHARACTER_RECOGNIZER.frmattachmentreport();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
               this.panel1.Controls.Add(this.userid);
               this.panel1.Controls.Add(this.lbluser);
               this.panel1.Controls.Add(this.pictureBox1);
               this.panel1.Controls.Add(this.label13);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(848, 100);
               this.panel1.TabIndex = 2;
               // 
               // userid
               // 
               this.userid.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.userid.AutoSize = true;
               this.userid.BackColor = System.Drawing.Color.Transparent;
               this.userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.userid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.userid.Location = new System.Drawing.Point(743, 31);
               this.userid.Name = "userid";
               this.userid.Size = new System.Drawing.Size(24, 16);
               this.userid.TabIndex = 8;
               this.userid.Text = "00";
               // 
               // lbluser
               // 
               this.lbluser.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.lbluser.AutoSize = true;
               this.lbluser.BackColor = System.Drawing.Color.Transparent;
               this.lbluser.ForeColor = System.Drawing.SystemColors.HighlightText;
               this.lbluser.Location = new System.Drawing.Point(789, 31);
               this.lbluser.Name = "lbluser";
               this.lbluser.Size = new System.Drawing.Size(88, 13);
               this.lbluser.TabIndex = 7;
               this.lbluser.Text = "DANIEL NGAHU";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(698, 31);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(29, 26);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 5;
               this.pictureBox1.TabStop = false;
               // 
               // label13
               // 
               this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label13.AutoSize = true;
               this.label13.BackColor = System.Drawing.Color.Transparent;
               this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
               this.label13.Location = new System.Drawing.Point(807, 55);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(37, 13);
               this.label13.TabIndex = 4;
               this.label13.Text = "Online";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label1.Location = new System.Drawing.Point(262, 52);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(361, 16);
               this.label1.TabIndex = 0;
               this.label1.Text = "ATTACHMENT REPORT  MANAGEMENT MODULE";
               // 
               // crystalReportViewer1
               // 
               this.crystalReportViewer1.ActiveViewIndex = 0;
               this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
               this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.crystalReportViewer1.Location = new System.Drawing.Point(0, 100);
               this.crystalReportViewer1.Name = "crystalReportViewer1";
               this.crystalReportViewer1.ReportSource = this.frmattachmentreport1;
               this.crystalReportViewer1.Size = new System.Drawing.Size(848, 397);
               this.crystalReportViewer1.TabIndex = 3;
               // 
               // frmattachreport
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(848, 497);
               this.Controls.Add(this.crystalReportViewer1);
               this.Controls.Add(this.panel1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "frmattachreport";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          public System.Windows.Forms.Label userid;
          public System.Windows.Forms.Label lbluser;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.Label label13;
          private System.Windows.Forms.Label label1;
          private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
          private frmattachmentreport frmattachmentreport1;
     }
}