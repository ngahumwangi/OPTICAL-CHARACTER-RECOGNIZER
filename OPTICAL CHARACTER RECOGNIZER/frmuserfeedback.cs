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

namespace OPTICAL_CHARACTER_RECOGNIZER
{
     public partial class frmuserfeedback : Form
     {
          public frmuserfeedback()
          {
               InitializeComponent();
          }
          ConnectionString cs = new ConnectionString();
          private void frmuserfeedback_Load(object sender, EventArgs e)
          {

          }

          private void btncancel_Click(object sender, EventArgs e)
          {
               //reset control
               txtsubject.Text = "";
               txtmessage.Text = "";
               rdob.Checked = false;
               rdoe.Checked = false;
               rdog.Checked = false;
               rdom.Checked = false;
               rdovg.Checked = false;
               txtsubject.Focus();
          }
          private int rate()
          {
               int rate=0;
               if(rdob.Checked==true)
               {
                    rate = 20;
               }
               else if(rdom.Checked==true)
               {
                    rate = 40;
               }
               else if(rdog.Checked==true)
               {
                    rate = 60;
               }
               else if(rdovg.Checked==true)
               {
                    rate = 80;
               }
               else if (rdoe.Checked==true)
               {
                    rate = 100;
               }
               return rate;
          }

          private void btnsave_Click(object sender, EventArgs e)
          {
               //insert feedback
               try
               {
                   if(txtsubject.Text=="")
                   {
                        MessageBox.Show("Message Subject Required!");
                        return;
                   }
                   else if(txtmessage.Text=="")
                   {
                        MessageBox.Show("messange Required");
                        return;
                   }
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    myconn1.Open();
                    frmdashboard fr=new frmdashboard();
                    string Query1 = "insert into user_feedaback(user_id,subject,message,satis_rate) values('" + userid.Text + "','" + txtsubject.Text + "','" + txtmessage.Text + "','" + rate() + "')";

                    MySqlCommand mycommand1 = new MySqlCommand(Query1, myconn1);
                    MySqlDataReader myreader1;

                    myreader1 = mycommand1.ExecuteReader();//execution command


                    MessageBox.Show("User FeedBack Acknowedged !");
                    //reset control
                    txtsubject.Text = "";
                    txtmessage.Text = "";
                    rdob.Checked = false;
                    rdoe.Checked = false;
                    rdog.Checked = false;
                    rdom.Checked = false;
                    rdovg.Checked = false;
                    txtsubject.Focus();
                    myconn1.Close();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex+ "Error Contact admin" );
               }

          }

          private void btnexit_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
