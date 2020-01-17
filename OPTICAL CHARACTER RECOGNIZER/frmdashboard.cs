using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OPTICAL_CHARACTER_RECOGNIZER
{
    public partial class frmdashboard : Form
    {
        Timer timer1 = new Timer();
        public frmdashboard()
        {
            InitializeComponent();
            try
            {
              
                this.lbldate.Text = DateTime.Now.ToString();
                timer1.Tick += new EventHandler(timer1_Tick);
                this.timer1.Interval = 1000;
                this.timer1.Enabled = true;
            }
            catch 
            {
              
            }
        }
        private void timer1_Tick(Object sender, EventArgs e)
        {

            this.lbldate.Text = DateTime.Now.ToString();
            getunreadcount();
            notification();            
            if (Convert.ToBoolean(timer1.Tag) == true)
            {
                 btnfeedback.ForeColor = Color.Aqua;

                 timer1.Tag = false;

            }

            else
            {
                 btnfeedback.ForeColor = Color.DarkGreen;

                 timer1.Tag = true;
            }
        }

        ConnectionString cs = new ConnectionString();
        MySqlTransaction trans = null;
        MySqlConnection con = null;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin fr = new frmlogin();
            this.Hide();
            fr.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

             var result = MessageBox.Show("Are you sure you want to exit?", "Application Exit", MessageBoxButtons.YesNo);
             if (result == DialogResult.Yes)
             {
                  Application.Exit();
             }
             else
             {
                  return;
             }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
             //call about us form
             frmaboutus fr = new frmaboutus();
             fr.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("StikyNot.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
            try
            {
                System.Diagnostics.Process.Start("WINWORD.EXE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    

        private void button4_Click(object sender, EventArgs e)
        {
            frmusers fr = new frmusers();
            fr.lbluser.Text = lbluser.Text;
            fr.userid.Text = userid.Text;
            fr.ShowDialog();
        }



        private void getunreadcount()
        {
             string read = "UNREAD";
             MySqlConnection conn = new MySqlConnection(cs.myconnection1);
             conn.Open();
             string query = "select   COUNT(*) from  customer_notification WHERE user_id='" + Convert.ToInt32(userid.Text) + "' AND 	status='"+read+"'";
             MySqlCommand mycommand1 = new MySqlCommand(query, conn);

             string x = mycommand1.ExecuteScalar().ToString();//execution command 
             lblnotification.Text = x;
            
        }
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmusers fr = new frmusers();
            fr.lbluser.Text = lbluser.Text;
            fr.userid.Text = userid.Text;
            fr.ShowDialog();
        }
         private void notification()
        {
              try
              {
                   string read = "UNREAD";
                   MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                   myconn1.Open();
                   string query = "select notification_subject AS NOTIFICATION FROM customer_notification WHERE user_id='" + Convert.ToInt32(userid.Text) + "' AND 	status='"+read+"' order by notification_id DESC";

                   MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);

                   MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                   myadapter.SelectCommand = mycommand1;
                   DataTable dTable = new DataTable();
                   myadapter.Fill(dTable);
                   dgvnot.DataSource = dTable;
              }
              catch
              {
                   MessageBox.Show("Unable to check the messages ,please check the database");
                   return;
              }
        }
        private void frmdashboard_Load(object sender, EventArgs e)
        {
             if (lblRole.Text == "Customer")
             {
                  //control custom user
                  btnusers.Enabled = false;
                  btnnotifications.Enabled = false;
                  btnmessage.Enabled = false;
                  mmmanagenoti.Enabled = false;
                  toolStripMenuItem2.Enabled = false;
                  mmusers.Enabled = false;
                  mmbackup.Enabled = false;
                  toolStripMenuItem4.Enabled = false;




             }
          
             lbltitle.Text = "WELCOME ONBOARD " + lbluser2.Text.ToUpper() + " PLEASE CHECK YOUR NOTIFICATION AND LETTERS ";
             MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
             myconn1.Open();

             string query = "select userid AS USER_ID,gender AS GENDER,role AS USER_ROLE,username AS USERNAME  from users order by userid DESC LIMIT 5";

             MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);

             MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
             myadapter.SelectCommand = mycommand1;
             DataTable dTable = new DataTable();
             myadapter.Fill(dTable);
             dgvusers.DataSource = dTable;

             /***getnotification****/

             getunreadcount();
             notification();
             pie();

             bar();


        }
         private void pie()
        {

             // Create a pie series.
             //AddXY value in chart1 in series named as Salary  
             chart1.Series["user"].Points.AddXY("Excellent", getExcellent());
             chart1.Series["user"].Points.AddXY("Very Good", getVeryGood());
             chart1.Series["user"].Points.AddXY("Good", getGood());
             chart1.Series["user"].Points.AddXY("Moderate", getModerate());
             chart1.Series["user"].Points.AddXY("Bad", getBad());
             //chart title  
        }
         private int getmale()
         {

              MySqlConnection conn = new MySqlConnection(cs.myconnection1);
              conn.Open();
              string query = "select   COUNT(gender) from  users WHERE gender='male'";
              MySqlCommand mycommand1 = new MySqlCommand(query, conn);

              int x = Convert.ToInt32(mycommand1.ExecuteScalar());//execution command 

              return x *100;
         }
         private int getfemale()
         {

              MySqlConnection conn = new MySqlConnection(cs.myconnection1);
              conn.Open();
              string query = "select   COUNT(gender) from  users WHERE gender='female'";
              MySqlCommand mycommand1 = new MySqlCommand(query, conn);

              int x = Convert.ToInt32(mycommand1.ExecuteScalar());//execution command 

              return x *100;
         }
         private void bar()
         {
              chart2.Series["barchart"].Points.AddXY("Male", getmale());
              chart2.Series["barchart"].Points.AddXY("Female", getfemale());
         }
        private int  getExcellent()
        {
             
             MySqlConnection conn = new MySqlConnection(cs.myconnection1);
             conn.Open();
             string query = "select   COUNT(satis_rate) from  user_feedaback WHERE satis_rate=100";
             MySqlCommand mycommand1 = new MySqlCommand(query, conn);

          int  x = Convert.ToInt32(mycommand1.ExecuteScalar());//execution command 
         
             return x;
        }
        private int getVeryGood()
        {

             MySqlConnection conn = new MySqlConnection(cs.myconnection1);
             conn.Open();
             string query = "select   COUNT(satis_rate) from  user_feedaback WHERE satis_rate=80";
             MySqlCommand mycommand1 = new MySqlCommand(query, conn);

             int x = Convert.ToInt32(mycommand1.ExecuteScalar());//execution command 

             return x;
        }
        private int getGood()
        {

             MySqlConnection conn = new MySqlConnection(cs.myconnection1);
             conn.Open();
             string query = "select   COUNT(satis_rate) from  user_feedaback WHERE satis_rate=60";
             MySqlCommand mycommand1 = new MySqlCommand(query, conn);

             int x = Convert.ToInt32(mycommand1.ExecuteScalar());//execution command 

             return x;
        }
        private int getModerate()
        {

             MySqlConnection conn = new MySqlConnection(cs.myconnection1);
             conn.Open();
             string query = "select   COUNT(satis_rate) from  user_feedaback WHERE satis_rate=40";
             MySqlCommand mycommand1 = new MySqlCommand(query, conn);

             int x = Convert.ToInt32(mycommand1.ExecuteScalar());//execution command 

             return x;
        }
        private int getBad()
        {

             MySqlConnection conn = new MySqlConnection(cs.myconnection1);
             conn.Open();
             string query = "select   COUNT(satis_rate) from  user_feedaback WHERE satis_rate=20";
             MySqlCommand mycommand1 = new MySqlCommand(query, conn);

             int x = Convert.ToInt32(mycommand1.ExecuteScalar());//execution command 

             return x;
        }
        private void button2_Click(object sender, EventArgs e)
        {
             frmnotification fr = new frmnotification();
             fr.lbluser.Text = lbluser.Text;
             fr.userid.Text = userid.Text;
             fr.ShowDialog();
        }

        private void btndb_Click(object sender, EventArgs e)
        {
             MessageBox.Show("There is no need you are already on the dashBoard");
             return;
        }

        private void mmmanagenoti_Click(object sender, EventArgs e)
        {
             frmnotification fr = new frmnotification();
             fr.lbluser.Text = lbluser.Text;
             fr.userid.Text = userid.Text;
             fr.ShowDialog();
        }

        private void mmnoti_Click(object sender, EventArgs e)
        {
             frmusernotification fr = new frmusernotification();
             fr.lbluser.Text = lbluser.Text;
             fr.userid.Text = userid.Text;
             fr.ShowDialog();
        }

        private void mmusers_Click(object sender, EventArgs e)
        {
             frmusers fr = new frmusers();
             fr.lbluser.Text = lbluser.Text;
             fr.userid.Text = userid.Text;
             fr.ShowDialog();
        }

        private void mmbackup_Click(object sender, EventArgs e)
        {
             frmdatabaseback fr = new frmdatabaseback();
             fr.lbluser.Text = lbluser.Text;
             fr.userid.Text = userid.Text;
             fr.ShowDialog();
        }

       
        private void frmdashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
         var result= MessageBox.Show("About to Exit Leave us a feedback", "Application Exit", MessageBoxButtons.YesNo);
              switch (result)
             {
                  case DialogResult.Yes:
                frmuserfeedback fr = new frmuserfeedback();
                fr.lbluser.Text = lbluser.Text;
                fr.userid.Text = userid.Text;
                  fr.ShowDialog();
                  Application.Exit();
                  break;
                  case DialogResult.No:
                  Application.Exit();
                  break;
        }
            
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
             frmuserfeedback fr = new frmuserfeedback();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //open notification
             frmusernotification fr = new frmusernotification();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
             //open notification
             frmusernotification fr = new frmusernotification();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
             //
             frmcontent fr = new frmcontent();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
             frmcontent fr = new frmcontent();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
             frmviewcontent fr = new frmviewcontent();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
             frmuserreport fr = new frmuserreport();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void toolStripMenuItem13_Click_1(object sender, EventArgs e)
        {
             frmnotificationreport fr = new frmnotificationreport();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
             frmattachreport fr = new frmattachreport();
             fr.userid.Text = userid.Text;
             fr.lbluser.Text = lbluser.Text;
             fr.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }


       
    }
}
