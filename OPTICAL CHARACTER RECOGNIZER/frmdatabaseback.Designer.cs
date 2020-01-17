namespace OPTICAL_CHARACTER_RECOGNIZER
{
    partial class frmdatabaseback
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdatabaseback));
               this.panel2 = new System.Windows.Forms.Panel();
               this.btnbackup = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.userid = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.label4 = new System.Windows.Forms.Label();
               this.lbluser = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.panel3 = new System.Windows.Forms.Panel();
               this.btnrestore = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.panel2.SuspendLayout();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.panel3.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel2
               // 
               this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel2.Controls.Add(this.btnbackup);
               this.panel2.Controls.Add(this.label2);
               this.panel2.Location = new System.Drawing.Point(23, 79);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(682, 146);
               this.panel2.TabIndex = 1;
               // 
               // btnbackup
               // 
               this.btnbackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbackup.BackgroundImage")));
               this.btnbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnbackup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.btnbackup.Location = new System.Drawing.Point(272, 84);
               this.btnbackup.Name = "btnbackup";
               this.btnbackup.Size = new System.Drawing.Size(182, 47);
               this.btnbackup.TabIndex = 1;
               this.btnbackup.Text = "BackUp Database";
               this.btnbackup.UseVisualStyleBackColor = true;
               this.btnbackup.Click += new System.EventHandler(this.button1_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label2.Location = new System.Drawing.Point(43, 23);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(562, 48);
               this.label2.TabIndex = 0;
               this.label2.Text = "Note: Please keep backup database file to your local/file server or any directory" +
    "\r\n that anyone can\'t access it.\r\nClick Backup Database Button to download backup" +
    " file of your database.";
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel1.Controls.Add(this.userid);
               this.panel1.Controls.Add(this.pictureBox1);
               this.panel1.Controls.Add(this.label4);
               this.panel1.Controls.Add(this.lbluser);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(787, 73);
               this.panel1.TabIndex = 0;
               // 
               // userid
               // 
               this.userid.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.userid.AutoSize = true;
               this.userid.BackColor = System.Drawing.Color.Transparent;
               this.userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.userid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.userid.Location = new System.Drawing.Point(586, 10);
               this.userid.Name = "userid";
               this.userid.Size = new System.Drawing.Size(24, 16);
               this.userid.TabIndex = 7;
               this.userid.Text = "00";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
               this.pictureBox1.Location = new System.Drawing.Point(540, 10);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(29, 26);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 6;
               this.pictureBox1.TabStop = false;
               // 
               // label4
               // 
               this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.Transparent;
               this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
               this.label4.Location = new System.Drawing.Point(637, 28);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(37, 13);
               this.label4.TabIndex = 5;
               this.label4.Text = "Online";
               // 
               // lbluser
               // 
               this.lbluser.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.lbluser.AutoSize = true;
               this.lbluser.BackColor = System.Drawing.Color.Transparent;
               this.lbluser.Location = new System.Drawing.Point(616, 10);
               this.lbluser.Name = "lbluser";
               this.lbluser.Size = new System.Drawing.Size(88, 13);
               this.lbluser.TabIndex = 4;
               this.lbluser.Text = "DANIEL NGAHU";
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label1.Location = new System.Drawing.Point(323, 32);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(131, 16);
               this.label1.TabIndex = 0;
               this.label1.Text = "Database backup";
               // 
               // panel3
               // 
               this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
               this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel3.Controls.Add(this.btnrestore);
               this.panel3.Controls.Add(this.label3);
               this.panel3.Location = new System.Drawing.Point(24, 231);
               this.panel3.Name = "panel3";
               this.panel3.Size = new System.Drawing.Size(682, 168);
               this.panel3.TabIndex = 2;
               // 
               // btnrestore
               // 
               this.btnrestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrestore.BackgroundImage")));
               this.btnrestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnrestore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.btnrestore.Location = new System.Drawing.Point(274, 98);
               this.btnrestore.Name = "btnrestore";
               this.btnrestore.Size = new System.Drawing.Size(182, 47);
               this.btnrestore.TabIndex = 1;
               this.btnrestore.Text = "Restore Database";
               this.btnrestore.UseVisualStyleBackColor = true;
               this.btnrestore.Click += new System.EventHandler(this.button1_Click_1);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.Transparent;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label3.Location = new System.Drawing.Point(224, 24);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(270, 16);
               this.label3.TabIndex = 0;
               this.label3.Text = "Note: CLick To Restore The database";
               // 
               // frmdatabaseback
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.ClientSize = new System.Drawing.Size(787, 408);
               this.Controls.Add(this.panel3);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "frmdatabaseback";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.panel3.ResumeLayout(false);
               this.panel3.PerformLayout();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbluser;
        public System.Windows.Forms.Label userid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnrestore;
        private System.Windows.Forms.Label label3;
    }
}