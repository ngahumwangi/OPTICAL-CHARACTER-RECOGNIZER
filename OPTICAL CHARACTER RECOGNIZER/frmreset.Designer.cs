namespace OPTICAL_CHARACTER_RECOGNIZER
{
     partial class frmreset
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreset));
               this.panel1 = new System.Windows.Forms.Panel();
               this.label1 = new System.Windows.Forms.Label();
               this.panel2 = new System.Windows.Forms.Panel();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.txtpassword = new System.Windows.Forms.TextBox();
               this.txtconfirm = new System.Windows.Forms.TextBox();
               this.btnupdate = new System.Windows.Forms.Button();
               this.lbluser = new System.Windows.Forms.Label();
               this.panel1.SuspendLayout();
               this.panel2.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel1.Controls.Add(this.lbluser);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(361, 50);
               this.panel1.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label1.Location = new System.Drawing.Point(47, 17);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(194, 16);
               this.label1.TabIndex = 0;
               this.label1.Text = "ENTER NEW PASSWORD ";
               // 
               // panel2
               // 
               this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel2.Controls.Add(this.btnupdate);
               this.panel2.Controls.Add(this.txtconfirm);
               this.panel2.Controls.Add(this.txtpassword);
               this.panel2.Controls.Add(this.label3);
               this.panel2.Controls.Add(this.label2);
               this.panel2.Location = new System.Drawing.Point(12, 56);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(314, 135);
               this.panel2.TabIndex = 1;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(18, 23);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(78, 13);
               this.label2.TabIndex = 0;
               this.label2.Text = "New Password";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(5, 58);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(91, 13);
               this.label3.TabIndex = 1;
               this.label3.Text = "Confirm Password";
               // 
               // txtpassword
               // 
               this.txtpassword.Location = new System.Drawing.Point(123, 23);
               this.txtpassword.Name = "txtpassword";
               this.txtpassword.PasswordChar = '*';
               this.txtpassword.Size = new System.Drawing.Size(164, 20);
               this.txtpassword.TabIndex = 2;
               // 
               // txtconfirm
               // 
               this.txtconfirm.Location = new System.Drawing.Point(123, 58);
               this.txtconfirm.Name = "txtconfirm";
               this.txtconfirm.PasswordChar = '*';
               this.txtconfirm.Size = new System.Drawing.Size(164, 20);
               this.txtconfirm.TabIndex = 3;
               // 
               // btnupdate
               // 
               this.btnupdate.Location = new System.Drawing.Point(112, 98);
               this.btnupdate.Name = "btnupdate";
               this.btnupdate.Size = new System.Drawing.Size(175, 23);
               this.btnupdate.TabIndex = 4;
               this.btnupdate.Text = "Update";
               this.btnupdate.UseVisualStyleBackColor = true;
               this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
               // 
               // lbluser
               // 
               this.lbluser.AutoSize = true;
               this.lbluser.BackColor = System.Drawing.Color.Transparent;
               this.lbluser.Location = new System.Drawing.Point(265, 19);
               this.lbluser.Name = "lbluser";
               this.lbluser.Size = new System.Drawing.Size(19, 13);
               this.lbluser.TabIndex = 1;
               this.lbluser.Text = "00";
               // 
               // reset
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(361, 211);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "reset";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.Button btnupdate;
          private System.Windows.Forms.TextBox txtconfirm;
          private System.Windows.Forms.TextBox txtpassword;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          public System.Windows.Forms.Label lbluser;
     }
}