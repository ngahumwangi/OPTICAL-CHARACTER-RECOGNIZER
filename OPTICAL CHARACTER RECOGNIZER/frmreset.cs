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
     
     public partial class frmreset : Form
     {
          public frmreset()
          {
               InitializeComponent();
          }
          Securitysha1 ss = new Securitysha1();//security
          ConnectionString cs = new ConnectionString();//databse connection
          private void btnupdate_Click(object sender, EventArgs e)
          {
               //confirm
               if(txtpassword.Text=="")
               {
                    MessageBox.Show("Password Required");
                    return;
               }
               else if(txtconfirm.Text=="")
               {
                    MessageBox.Show("Confirm the new Password");
                    return;
               }
               else
               {
                    if(txtpassword.Text!=txtconfirm.Text)
                    {
                         MessageBox.Show("Password do not match");
                         return;
                    }
                    else
                    {
                         string passresult = ss.GetSHA1(txtpassword.Text);
                         MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                         myconn1.Open();
                         string query = "update users set password='" + passresult + "'  where userid='" + Convert.ToInt64(lbluser.Text) + "'";
                         MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);
                         MySqlDataReader myreader1;

                         myreader1 = mycommand1.ExecuteReader();//execution command                       

                         MessageBox.Show("PASSWORD CHANGED");
                         frmlogin fr = new frmlogin();
                         this.Hide();
                         fr.Show();
                    }
               }
          }
     }
}
