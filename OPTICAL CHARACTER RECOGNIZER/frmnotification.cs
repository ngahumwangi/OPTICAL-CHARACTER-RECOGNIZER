using MySql.Data.MySqlClient;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPTICAL_CHARACTER_RECOGNIZER
{
    public partial class frmnotification : Form
    {
        public frmnotification()
        {
            InitializeComponent();
            cbostatus.Items.Add("READ");
            cbostatus.Items.Add("UNREAD");
        }
        ConnectionString cs = new ConnectionString();
        private void button3_Click(object sender, EventArgs e)
        {
             btnsave.Enabled = false;
            tabControl1.SelectedTab = tabPage3;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            dgvstock.Visible = true;    
            dgvstock.DataSource = null;
            dgvstock.Rows.Clear();                  
            btnupdate.Enabled = true;
            rdonotification.Checked = true;

               

        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
       

        private void btnsave_Click(object sender, EventArgs e)
        {
          
            checkemptyness();//a fuction call to refer tothe below fuction validating textbox emptyness
        }
        /*-------start of fuction of checking the emptyness-----*/
        private void checkemptyness()
        {
           
             if(cbostatus.Text=="")
             {
                  MessageBox.Show("Select the Notification StatusBar");
                  return;
             }
             if (txtsubject.Text == "")
            {
                MessageBox.Show("Please write the subject of the notification");
                txtsubject.Focus();
                return;
            }
            else if (txtnotificationmessage.Text == "")
            {
                MessageBox.Show("Indicate the notification message");
                txtnotificationmessage.Focus();
                return;
            }
           


            else
            {
                try
                {
                    DateTime date = dtpnotification.Value;
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    myconn1.Open();
                    string Query1 = "insert into customer_notification(user_id,notification_subject,nofication_body,status,notification_date) values((SELECT userid FROM users WHERE username='" + cbousers.SelectedItem + "'),'" + txtsubject.Text.ToUpper() + "','" + txtnotificationmessage.Text.ToUpper() + "','" + cbostatus.SelectedItem + "','" + date.ToString("yyyy-MM-dd") + "')";

                    MySqlCommand mycommand1 = new MySqlCommand(Query1, myconn1);
                    MySqlDataReader myreader1;

                    myreader1 = mycommand1.ExecuteReader();//execution command


                    MessageBox.Show("Notification data saved");
                    cleartextboxex();
                    this.Refresh();
                    while (myreader1.Read())
                    {

                    }
                    myconn1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save Notification data" );
                }

            }


            /*-------end of fuction of checking the emptyness-----*/
        }
        private void cleartextboxex()
        {   //clearing of the text after saving of datas
             cbousers.SelectedIndex = -1;            
            txtsubject.Text = "";
            txtnotificationmessage.Text = "";            
            dtpnotification.ResetText();
            cbostatus.SelectedIndex = -1;
            btnsave.Enabled = true;
            txtnotificationid.Text = "";
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            dgvstock.DataSource = null;
            dgvstock.Rows.Clear();
            dgvstock.Visible = false;
        }
        private void frmstock_Load(object sender, EventArgs e)
        {
             try
             {
                  string querry = "select username from users";
                  MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                  MySqlCommand mycommand1 = new MySqlCommand(querry, myconn1);
                  MySqlDataReader myreader1;
                  myconn1.Open();//mysql open of session
                  myreader1 = mycommand1.ExecuteReader();//execution command
                  /*------textbox clearance---*/

                  while (myreader1.Read())
                  {
                       object item = myreader1["username"];
                       cbousers.Items.Add(item.ToString());
                  }
                  myconn1.Close();
             }
             catch (Exception)
             {
                  MessageBox.Show("Unable to get the systesm users");
                  return;
             }
            tabPage3.Visible = false;
            btnupdate.Enabled = false;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
             
            
            //a  query to search the notification for for editing
             if (rdonotification.Checked == true)
            {
                try
                {
                    /* txtstocksearch.KeyPress(object sender, EventArgs e)
                     {

                     }*/
                    if (txtsearch.Text == null)
                    {
                        MessageBox.Show("NUll DATA!", "NULL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        
                       
                        MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                        myconn1.Open();
                        string query = "select notification_id As NOTIFICATION_ID,user_id AS TARGET_USER,notification_subject AS SUBJECT,nofication_body AS BODY,status AS STATUS,notification_date AS DATE FROM customer_notification where notification_subject like'%" + txtsearch.Text.ToUpper() + "%' or notification_id like'%" + txtsearch.Text.ToUpper() + "%' order by notification_id DESC";

                        MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);

                        MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                        myadapter.SelectCommand = mycommand1;
                        DataTable dTable = new DataTable();
                        myadapter.Fill(dTable);
                        dgvstock.DataSource = dTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NUll DATA", "STOP!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            
        }

        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date1 = dtpnotification.Value;
                MySqlConnection myconn2 = new MySqlConnection(cs.myconnection1);
                myconn2.Open();
                string query = "update customer_notification set notification_subject='" + txtsubject.Text + "',nofication_body='" + txtnotificationmessage.Text + "',status='" + cbostatus.SelectedItem + "' where notification_id='" + txtnotificationid.Text + "'";

                MySqlCommand mycommand2 = new MySqlCommand(query, myconn2);

                mycommand2.ExecuteNonQuery();//execution command
                MessageBox.Show("you succeful updated  the User Notification");
                myconn2.Close();
                cleartextboxex();
                btnupdate.Enabled = true;               
                btnsave.Enabled = false;
                rdonotification.Checked = true;
                groupBox2.Enabled = true;
                txtsearch.Focus();
                txtsubject.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error");
            }
        }
         private string usernam(int user_id)
        {
             MySqlConnection conn = new MySqlConnection(cs.myconnection1);
             conn.Open();
             string query = "select   username from   users WHERE userid='" + user_id + "'";
             MySqlCommand mycommand1 = new MySqlCommand(query, conn);
             string username = mycommand1.ExecuteScalar().ToString();//execution command

             return username;
        }
        private void mmedit_Click(object sender, EventArgs e)
        {
             //edit dgv content
             if(dgvstock.Rows.Count<1)
             {
                  MessageBox.Show("Please Search an Item to Edit");
                  return;
             }
             else
             {
                  try
                  {

                  DataGridViewRow dr = dgvstock.SelectedRows[0];

                  txtnotificationid.Text = dr.Cells[0].Value.ToString();
                  cbousers.SelectedIndex = cbousers.FindString(usernam(Convert.ToInt32(dr.Cells[1].Value)));              
                  txtsubject.Text = dr.Cells[2].Value.ToString();
                  txtnotificationmessage.Text = dr.Cells[3].Value.ToString();
                  cbostatus.SelectedIndex = cbostatus.FindString(dr.Cells[4].Value.ToString());
                  dtpnotification.Value = Convert.ToDateTime(dr.Cells[5].Value.ToString());
                  dgvstock.DataSource = null;
                  dgvstock.Rows.Clear();
                  tabControl1.SelectedTab = tabPage1;

                  /********/





                  }
                  catch (Exception ex)
                  {
                       MessageBox.Show("SORRY NO DATA!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
             }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
             cleartextboxex();

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
             txtsubject.Text = "";
             // open file dialog 
             OpenFileDialog open = new OpenFileDialog();
             // image filters
             open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png;*.bmp)|*.jpg; *.jpeg; *.gif; *.png;*.bmp";
             if (open.ShowDialog() == DialogResult.OK)
             {


                  string testImagePath = Path.GetFullPath(open.FileName);
             

                  try
                  {

                       using (var api = OcrApi.Create())
                       {
                            api.Init(Languages.English);
                            string plainText = api.GetTextFromImage(testImagePath);
                            txtsubject.Text = plainText;
                       }




                  }
                  catch (Exception ex)
                  {
                       Console.WriteLine("Unexpected Error During Conversion");
                       return;
                  }
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             txtfile.Text = "";
             txtconverted.Text = "";
             // open file dialog 
             OpenFileDialog open = new OpenFileDialog();
             // image filters
             open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png;*.bmp)|*.jpg; *.jpeg; *.gif; *.png;*.bmp";
             if (open.ShowDialog() == DialogResult.OK)
             {


                  string testImagePath = Path.GetFullPath(open.FileName);
                  txtfile.Text = testImagePath;

                  try
                  {

                       using (var api = OcrApi.Create())
                       {
                            api.Init(Languages.English);
                            string plainText = api.GetTextFromImage(testImagePath);
                            txtconverted.Text = plainText;
                       }




                  }
                  catch (Exception ex)
                  {
                       Console.WriteLine("Unexpected Error During Conversion");
                       return;
                  }
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             txtsubject.Text = txtconverted.Text;
        }

      

       
    }
}
