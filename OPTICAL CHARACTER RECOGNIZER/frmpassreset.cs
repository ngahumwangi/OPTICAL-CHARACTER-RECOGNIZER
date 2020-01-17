using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPTICAL_CHARACTER_RECOGNIZER
{
     public partial class frmpassreset : Form
     {
          public frmpassreset()
          {
               InitializeComponent();
          }
          ConnectionString cs = new ConnectionString();
          private void label2_Click(object sender, EventArgs e)
          {

          }

          private void textBox2_Validating(object sender, CancelEventArgs e)
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

          private void btnsend_Click(object sender, EventArgs e)
          {
               //validate
               if(txtusername.Text=="")
               {
                    MessageBox.Show("Enter Username");
                         return;
               }
               else if(txtemail.Text=="")
               {
                    MessageBox.Show("Enter Email associated with th above Username");
                    return;
               }
               else
               {
                    try
                    {
                         MySqlConnection myconn2 = new MySqlConnection(cs.myconnection1);
                         string query2 = "select userid, email ,username from users where username='" + txtusername.Text + "' ";
                         MySqlCommand mycommand2 = new MySqlCommand(query2, myconn2);
                         MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                         myadapter.SelectCommand = mycommand2;
                         DataSet ds2 = new DataSet();
                         myadapter.Fill(ds2);
                         if (ds2.Tables[0].Rows.Count<1)
                         {
                              MessageBox.Show("No Search username and email associated found in thes system");
                              txtusername.Text = "";
                              txtemail.Text = "";
                              return;
                         }
                         else
                         {
                              Random rand = new Random();
                              int random = rand.Next(12546,25567);


                              MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                              myconn1.Open();
                              string Query1 = "insert into passwordreset values('" + Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString()) + "','" + random + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";

                              MySqlCommand mycommand1 = new MySqlCommand(Query1, myconn1);
                              MySqlDataReader myreader1;


                              myreader1 = mycommand1.ExecuteReader();//execution command
                              
                              /*******send email******************/


                              MailMessage mail = new MailMessage();
                              SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                              mail.From = new MailAddress("ngahu01@gmail.com");
                              mail.To.Add(txtemail.Text.ToLower());
                              mail.Subject = "CONFIRMATION CODE FOR PASSWORD RESET[valid for 24hrs]";

                              mail.IsBodyHtml = true;
                              string htmlBody;
                              htmlBody = "<p>Enter the Code sent to reset the login password[valid for 24hrs].</p> <h1>" + random + "</h1> <br> <p>Copy the above code to the confirmation textbox [valid for 24hrs] </p>";

                              mail.Body = htmlBody;
                             

                              SmtpServer.Port = 587;
                              SmtpServer.Credentials = new System.Net.NetworkCredential("ngahu01@gmail.com", "danny4702");
                              SmtpServer.EnableSsl = true;

                              SmtpServer.Send(mail);
                           MessageBox.Show("A RESET CODE HAS BEEN SENT TO YOUR EMAIL<B> COPY THE CODE AND USE IT TO RESET YOUR PASSWORD ");
                           txtconfirmcode.Focus();


                         }
                    }
                    catch(Exception ex)
                    {
                         MessageBox.Show("Data Error");
                         return;
                    }
                   

               }
          }

          private void txtconfirmcode_KeyPress(object sender, KeyPressEventArgs e)
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

          private void btnconfim_Click(object sender, EventArgs e)
          {
               try
               { 
              if(txtconfirmcode.Text=="")
              {
                   MessageBox.Show("Enter Reset Code");
                   return;
              }
               //confirms the code 
               MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
               myconn1.Open();
               string Query = "select user_id from passwordreset WHERE  user_code='" + Convert.ToInt32(txtconfirmcode.Text) + "' and datetime='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ";//selection string

               MySqlCommand mycommand1 = new MySqlCommand(Query, myconn1);
               MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
               myadapter.SelectCommand = mycommand1;
               DataSet ds2 = new DataSet();
               myadapter.Fill(ds2);
                         if (ds2.Tables[0].Rows.Count >=1)
                         {
                              MessageBox.Show("RESET SUCCESSFULL");
                              frmreset fr = new frmreset();
                              fr.lbluser.Text=ds2.Tables[0].Rows[0][0].ToString();
                              this.Hide();
                              fr.Show();
                         }
                    else
                         {
                              MessageBox.Show("Wrong Code  contact admin");
                         }
               }
                    catch(Exception ex)
                         {
                              MessageBox.Show("Wrong Code  contact admin");
                         }
          }
     }
}
