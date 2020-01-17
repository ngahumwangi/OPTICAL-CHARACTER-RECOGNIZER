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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        ConnectionString cs = new ConnectionString();
        Securitysha1 ss = new Securitysha1();
        private void frmlogin_Load(object sender, EventArgs e)
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
                    cbousername.Items.Add(item.ToString());
                }
                myconn1.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error");
                return;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //prompting the ursor to move to the  button after key down event
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.Focus();
                e.Handled = true;
            }
        }

        private void cbopassword_KeyDown(object sender, KeyEventArgs e)
        {
            //prompting the ursor to move to the  button after key down event
            if (e.KeyCode == Keys.Enter)
            {
               txtpassword.Focus();
                e.Handled = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //validation
            if (cbousername.Text== "")
            {
                return;

            }
            else if (txtpassword.Text == "")
            {
                return;
            }
            else
            {
                bool r = validate_login(cbousername.Text, txtpassword.Text);
                if (r == true)
                {
                     frmdashboard cs = new frmdashboard();
                     //PharmSoft cs = new PharmSoft();
                     this.Hide();
                     cs.lbluser.Text = fullname;
                     cs.lbluser2.Text = fullname;
                     cs.userid.Text = userid;                    
                     cs.lblRole.Text = role;
                    
                     cs.Show();


                }

                else
                {

                    cbousername.SelectedIndex = -1;
                    txtpassword.Text = "";
                    



                }

            }
        }

        string userid = "";
        string username = "";
        string fullname = "";
        string role = "";
        public bool validate_login(string user, string pass)
        {
            string password = ss.GetSHA1(txtpassword.Text);
            bool ret = false;
            try
            {

                //dbconnection();//reffering to connection function defined above
                DataSet ds2 = new DataSet();

                string query = "select username,password,role,userid,fname ,othername from users where username='" + cbousername.SelectedItem + "' and password='" + password + "'";//sql query to select from mysql databse
                MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                MySqlCommand mycommand1 = new MySqlCommand();
                MySqlDataAdapter myreader1 = new MySqlDataAdapter(query, myconn1);
                int s = (myreader1.Fill(ds2));
                if (s == 1)
                {

                    username = ds2.Tables[0].Rows[0][0].ToString();//assign the first item in the array to user_id
                    role = ds2.Tables[0].Rows[0][2].ToString();//assign the 2nd item in the array to user_id
                    userid = ds2.Tables[0].Rows[0][3].ToString();
                    fullname = ds2.Tables[0].Rows[0][4].ToString() + "  " + ds2.Tables[0].Rows[0][5].ToString();//Get full names
                    ret = true;

                }
                else if (s < 1)
                {
                    ret = false;
                    cbousername.SelectedIndex = -1;
                    txtpassword.Text = "";

                }
                else if (s > 1)
                {
                    ret = false;

                    cbousername.SelectedIndex = -1;
                    txtpassword.Text = "";
                }
                else
                {
                    ret = false;
                    cbousername.SelectedIndex = -1;
                    txtpassword.Text = "";
                }
            }
            catch
            {
                
            }

            return ret;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
    }
}
