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
    public partial class frmusers : Form
    {
        public frmusers()
        {
            InitializeComponent();
            cbogender.Items.Add("female");
            cbogender.Items.Add("male");
           cborole.Items.Add("Admin");
           cborole.Items.Add("Customer");
          
        }
        Securitysha1 ss = new Securitysha1();
        ConnectionString cs = new ConnectionString();
        private int getid()
        {
            MySqlConnection conn = new MySqlConnection(cs.myconnection1);
            conn.Open();
            string query = "select   max(userid) from   users";
            MySqlCommand mycommand1 = new MySqlCommand(query, conn);
            string x = mycommand1.ExecuteScalar().ToString();//execution command
            int y = Convert.ToInt32(x) + 1;
            return y;
        }
        private void clear()
        {
            btnupdate.Visible = false;
            txtfname.Text = "";
            txtoname.Text = "";
            txttelno.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            txtemail.Text = "";
            txtid.Text = "";
            cborole.SelectedIndex = -1;
           txtconfirm.Text = "";
            dgvusers.DataSource = null;
            dgvusers.Rows.Clear();
           cbogender.SelectedIndex=-1;
           rdouserid.Checked = true;
            txtsearch.Text = "";


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtfname.Text=="")
            {
                MessageBox.Show("First Name is Required!");
                return;
            }
            else if(txtoname.Text=="")
            {
                MessageBox.Show("Other Name Please");
                return;
            }
            else if(cbogender.SelectedItem=="")
            {
                MessageBox.Show("Gender is Required!");
                return;
            }
            else if(cborole.SelectedItem=="")
            {

                MessageBox.Show("Please describe the user role!");
                return;
            }
            else if(txtusername.Text=="")
            {
                MessageBox.Show("Username is required");
                return;
            }
            else if (txtpassword.Text=="")
            {
                MessageBox.Show("Password is Required");
                return;
            }
            else if (txtconfirm.Text=="")
            {
                MessageBox.Show("Please confirm your password");
                return;
            }
            else if(txtpassword.Text!=txtconfirm.Text)
            {
                MessageBox.Show("Your password donot match");
                return;
            }
            else
            {
                string passresult = ss.GetSHA1(txtpassword.Text);
                try
                {
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    myconn1.Open();
                    string Query1 = "insert into users(userid,fname,othername,idno,email,telno,gender,role,username,password,dateofregistration) values('" + getid() + "','" + txtfname.Text + "','" + txtoname.Text + "','" + Convert.ToInt64(txtid.Text) + "','" + txtemail.Text + "','" + txttelno.Text + "','" + cbogender.SelectedItem + "','" + cborole.SelectedItem + "','" + txtusername.Text + "','" + passresult + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    MySqlCommand mycommand1 = new MySqlCommand(Query1, myconn1);
                    MySqlDataReader myreader1;


                    myreader1 = mycommand1.ExecuteReader();//execution command
                    /*------textbox clearance---*/

                    MessageBox.Show("Saved");
                    clear();
                    Application.Exit();
                    myconn1.Close();
                }
                catch(Exception )
                {
                    MessageBox.Show("Database Error");
                        return;
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            txtsearch.Focus();
            rdousername.Checked = true;
            btnsave.Visible = false;          
            btnupdate.Visible = true;
          
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

              if(txtfname.Text=="")
            {
                MessageBox.Show("First Name is Required!");
                return;
            }
            else if(txtoname.Text=="")
            {
                MessageBox.Show("Other Name Please");
                return;
            }
            else if(cbogender.SelectedItem=="")
            {
                MessageBox.Show("Gender is Required!");
                return;
            }
            else if(cborole.SelectedItem=="")
            {

                MessageBox.Show("Please describe the user role!");
                return;
            }
            else if(txtusername.Text=="")
            {
                MessageBox.Show("Username is required");
                return;
            }
            else if (txtpassword.Text=="")
            {
                MessageBox.Show("Password is Required");
                return;
            }
            else if (txtconfirm.Text=="")
            {
                MessageBox.Show("Please confirm your password");
                return;
            }
              else if (txtpassword.Text != txtconfirm.Text)
              {
                  MessageBox.Show("Your password donot match");
                  return;
              }
              else
              {
                  try
                  {
                      string passresult = ss.GetSHA1(txtpassword.Text);
                      MySqlConnection conn3 = new MySqlConnection(cs.myconnection1);
                      conn3.Open();
                      string query3 = "update users set fname='" + txtfname.Text + "',othername='" + txtoname.Text + "',idno='" + Convert.ToInt64(txtid.Text) + "',email='" + txtemail.Text + "',telno='" + Convert.ToInt64(txttelno.Text) + "',gender='" + cbogender.SelectedItem + "',role='" + cborole.SelectedItem + "',username='" + txtusername.Text + "',password='" + passresult + "'  where userid='" + Convert.ToInt64(txtuserid.Text) + "'";

                      MySqlCommand cmd = new MySqlCommand(query3, conn3);
                      MySqlDataReader myreader1;

                      myreader1 = cmd.ExecuteReader();//execution command
                      conn3.Close();
                      MessageBox.Show("you succefully updated  the user Details");
                      clear();
                      Application.Exit();
                  }
                  catch(Exception ex)
                  {
                      MessageBox.Show("Database Error");
                      return;
                  }
              }
        }

        private void frmusers_Load(object sender, EventArgs e)
        {

            btnupdate.Visible = false;
           panel3.Visible = false;
           // lbtnRemove_User.Visible = false;
           

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (rdouserid.Checked == true)
            {
                try
                {
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    myconn1.Open();
                    string query = "SELECT  userid AS USERID,fname AS FIRST_NAME ,othername AS LAST_NAME,username AS USERNAME from users where userid like'%" + txtsearch.Text + "%' order by userid";
                    MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                    MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                    myadapter.SelectCommand = mycommand1;
                    DataTable dTable = new DataTable();
                    myadapter.Fill(dTable);
                    dgvusers.DataSource = dTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error");
                    return;
                }
            }
            if (rdousername.Checked == true)
            {
                try
                {
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    myconn1.Open();
                    string query = "SELECT  userid AS USERID,fname AS FIRST_NAME ,othername AS LAST_NAME,username AS USERNAME from users where username like'%" + txtsearch.Text + "%' order by userid";
                    MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                    MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                    myadapter.SelectCommand = mycommand1;
                    DataTable dTable = new DataTable();
                    myadapter.Fill(dTable);
                    dgvusers.DataSource = dTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("database Error");
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            if (rdouserid.Checked == true)
            {
                try
                {
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    myconn1.Open();
                    string query = "SELECT  userid AS USERID,fname AS FIRST_NAME ,othername AS LAST_NAME,username AS USERNAME from users where userid like'%" + txtsearch.Text + "%' order by userid";
                    MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                    MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                    myadapter.SelectCommand = mycommand1;
                    DataTable dTable = new DataTable();
                    myadapter.Fill(dTable);
                    dgvusers.DataSource = dTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error");
                    return;
                }
            }
            if (rdousername.Checked == true)
            {
                try
                {
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    myconn1.Open();
                    string query = "SELECT  userid AS USERID,fname AS FIRST_NAME ,othername AS LAST_NAME,username AS USERNAME from users where username like'%" + txtsearch.Text + "%' order by userid";
                    MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                    MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                    myadapter.SelectCommand = mycommand1;
                    DataTable dTable = new DataTable();
                    myadapter.Fill(dTable);
                    dgvusers.DataSource = dTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("database Error");
                }
            }
        }

        private void dgvusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MySqlConnection myconn2 = new MySqlConnection(cs.myconnection1);

                string query2 = "select  	userid,fname,othername,idno,email,telno,gender,role ,username from users where userid='" + dgvusers.CurrentRow.Cells[0].FormattedValue + "' ";

                MySqlCommand mycommand2 = new MySqlCommand(query2, myconn2);
                MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                myadapter.SelectCommand = mycommand2;
                DataSet ds2 = new DataSet();
                myadapter.Fill(ds2);
                txtuserid.Text = ds2.Tables[0].Rows[0][0].ToString();
                txtfname.Text = ds2.Tables[0].Rows[0][1].ToString();
                txtoname.Text = ds2.Tables[0].Rows[0][2].ToString();
                txtid.Text = ds2.Tables[0].Rows[0][3].ToString();
                txtemail.Text = ds2.Tables[0].Rows[0][4].ToString();
                txttelno.Text = ds2.Tables[0].Rows[0][5].ToString();
                string x = ds2.Tables[0].Rows[0][6].ToString();
                string g = ds2.Tables[0].Rows[0][7].ToString();
                if (x == "male")
                {
                    cbogender.SelectedIndex = 1;
                }
                else
                {
                    cbogender.SelectedIndex = 0;
                }
                if (g == "Admin")
                {
                    cborole.SelectedIndex = 0;
                }
                else if (g == "Pharmacist")
                {
                    cborole.SelectedIndex = 1;
                }
                else if (g == "Receptionist")
                {
                    cborole.SelectedIndex = 2;
                }
                else if (g == "Doctor")
                {
                    cborole.SelectedIndex = 3;
                }
                
                txtusername.Text = ds2.Tables[0].Rows[0][8].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("SORRY NO DATA!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
            btnupdate.Visible = false;
            panel3.Visible = false;
            btnsave.Visible = true;
           
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
             System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

             if (txtemail.Text.Length > 0 && txtemail.Text.Trim().Length != 0)
             {
                  if (!rEmail.IsMatch(txtemail.Text.Trim()))
                  {
                       MessageBox.Show("Please enter a valid email address");
                       txtemail.SelectAll();
                       e.Cancel = true;
                  }
             }
        }
    }
}
