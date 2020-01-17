namespace OPTICAL_CHARACTER_RECOGNIZER
{
     partial class frmpassreset
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpassreset));
               this.panel2 = new System.Windows.Forms.Panel();
               this.txtconfirmcode = new System.Windows.Forms.TextBox();
               this.btnconfim = new System.Windows.Forms.Button();
               this.label5 = new System.Windows.Forms.Label();
               this.btnsend = new System.Windows.Forms.Button();
               this.txtemail = new System.Windows.Forms.TextBox();
               this.txtusername = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.label1 = new System.Windows.Forms.Label();
               this.panel2.SuspendLayout();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel2
               // 
               this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel2.Controls.Add(this.txtconfirmcode);
               this.panel2.Controls.Add(this.btnconfim);
               this.panel2.Controls.Add(this.label5);
               this.panel2.Controls.Add(this.btnsend);
               this.panel2.Controls.Add(this.txtemail);
               this.panel2.Controls.Add(this.txtusername);
               this.panel2.Controls.Add(this.label3);
               this.panel2.Controls.Add(this.label7);
               this.panel2.Controls.Add(this.label2);
               this.panel2.Location = new System.Drawing.Point(26, 79);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(780, 316);
               this.panel2.TabIndex = 3;
               // 
               // txtconfirmcode
               // 
               this.txtconfirmcode.Location = new System.Drawing.Point(297, 228);
               this.txtconfirmcode.Name = "txtconfirmcode";
               this.txtconfirmcode.Size = new System.Drawing.Size(180, 20);
               this.txtconfirmcode.TabIndex = 11;
               this.txtconfirmcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconfirmcode_KeyPress);
               // 
               // btnconfim
               // 
               this.btnconfim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconfim.BackgroundImage")));
               this.btnconfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnconfim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.btnconfim.Location = new System.Drawing.Point(260, 268);
               this.btnconfim.Name = "btnconfim";
               this.btnconfim.Size = new System.Drawing.Size(242, 41);
               this.btnconfim.TabIndex = 10;
               this.btnconfim.Text = "Confirm Reset Code";
               this.btnconfim.UseVisualStyleBackColor = true;
               this.btnconfim.Click += new System.EventHandler(this.btnconfim_Click);
               // 
               // label5
               // 
               this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.Transparent;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label5.Location = new System.Drawing.Point(294, 195);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(168, 16);
               this.label5.TabIndex = 9;
               this.label5.Text = "Enter Reset Code Here";
               // 
               // btnsend
               // 
               this.btnsend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend.BackgroundImage")));
               this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnsend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.btnsend.Location = new System.Drawing.Point(277, 149);
               this.btnsend.Name = "btnsend";
               this.btnsend.Size = new System.Drawing.Size(256, 33);
               this.btnsend.TabIndex = 8;
               this.btnsend.Text = "Send Reset Code";
               this.btnsend.UseVisualStyleBackColor = true;
               this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
               // 
               // txtemail
               // 
               this.txtemail.Location = new System.Drawing.Point(335, 90);
               this.txtemail.Name = "txtemail";
               this.txtemail.Size = new System.Drawing.Size(180, 20);
               this.txtemail.TabIndex = 7;
               this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
               // 
               // txtusername
               // 
               this.txtusername.Location = new System.Drawing.Point(335, 43);
               this.txtusername.Name = "txtusername";
               this.txtusername.Size = new System.Drawing.Size(180, 20);
               this.txtusername.TabIndex = 6;
               // 
               // label3
               // 
               this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.Transparent;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label3.Location = new System.Drawing.Point(192, 94);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(47, 16);
               this.label3.TabIndex = 5;
               this.label3.Text = "Email";
               // 
               // label7
               // 
               this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label7.AutoSize = true;
               this.label7.BackColor = System.Drawing.Color.Transparent;
               this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label7.Location = new System.Drawing.Point(192, 48);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(86, 16);
               this.label7.TabIndex = 4;
               this.label7.Text = "User Name";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label2.Location = new System.Drawing.Point(192, 10);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(323, 16);
               this.label2.TabIndex = 0;
               this.label2.Text = "Enter the Username and the Assoscited Email";
               this.label2.Click += new System.EventHandler(this.label2_Click);
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel1.Controls.Add(this.label1);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(850, 73);
               this.panel1.TabIndex = 2;
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label1.Location = new System.Drawing.Point(327, 28);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(176, 16);
               this.label1.TabIndex = 0;
               this.label1.Text = "Password Reset Module";
               // 
               // frmpassreset
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(850, 407);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "frmpassreset";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Button btnsend;
          private System.Windows.Forms.TextBox txtemail;
          private System.Windows.Forms.TextBox txtusername;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.TextBox txtconfirmcode;
          private System.Windows.Forms.Button btnconfim;
     }
}