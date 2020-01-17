
using MySql.Data.MySqlClient;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OPTICAL_CHARACTER_RECOGNIZER
{
     public partial class frmcontent : Form
     {
          public frmcontent()
          {
               InitializeComponent();
          }
         
     
          Securitysha1 ss = new Securitysha1();
          ConnectionString cs = new ConnectionString();
          private void Form1_Load(object sender, EventArgs e)
          {
               try
               {
                    string querry = "select category_name from letter_category";
                    MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                    MySqlCommand mycommand1 = new MySqlCommand(querry, myconn1);
                    MySqlDataReader myreader1;
                    myconn1.Open();//mysql open of session
                    myreader1 = mycommand1.ExecuteReader();//execution command
                    /*------textbox clearance---*/

                    while (myreader1.Read())
                    {
                         object item = myreader1["category_name"];
                         cbocategoryname.Items.Add(item.ToString());
                    }
                    myconn1.Close();
               }
               catch (Exception)
               {
                    MessageBox.Show("Unable to Get the Category Name");
                    return;
               }
          }

          private void btnsave_Click(object sender, EventArgs e)
          {

               //validate
               if (txtcategoryname.Text == "")
               {
                    MessageBox.Show("Write Name");
                    return;
               }
               else
               {
                    try
                    {
                         MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                         myconn1.Open();
                         string Query1 = "INSERT INTO  letter_category (category_name) values ('" + txtcategoryname.Text + "')";

                         MySqlCommand mycommand1 = new MySqlCommand(Query1, myconn1);
                         MySqlDataReader myreader1;


                         myreader1 = mycommand1.ExecuteReader();//execution command
                         /*------textbox clearance---*/

                         MessageBox.Show("Category Saved");
                         txtcategoryid.Text = "";
                         txtcategoryname.Text = "";
                         btnsave.Enabled = true;
                         btnupdate.Enabled = false;
                         myconn1.Close();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex + "Database Error");
                         return;
                    }
               }
          }

          private void btnedit_Click(object sender, EventArgs e)
          {
               //edit the category name
               btnsave.Enabled = false;
               btnupdate.Enabled = true;
               txtcategoryname.Focus();

          }

          private void txtcategoryname_TextChanged(object sender, EventArgs e)
          {
               if (btnsave.Enabled == false)
               {
                    try
                    {
                         txtcategoryname.AutoCompleteMode = AutoCompleteMode.Suggest;
                         txtcategoryname.AutoCompleteSource = AutoCompleteSource.CustomSource;
                         AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                         MySqlConnection conn = new MySqlConnection(cs.myconnection1);
                         conn.Open();
                         string query = "select category_name from letter_category  where category_name like'%" + txtcategoryname.Text.ToUpper() + "%' ";
                         MySqlCommand mycommand1 = new MySqlCommand(query, conn);
                         MySqlDataReader reader = mycommand1.ExecuteReader();

                         while (reader.Read())
                         {
                              col.Add(reader.GetString(0));
                         }
                         txtcategoryname.AutoCompleteCustomSource = col;
                         conn.Close();



                    }
                    catch
                    {
                    }
               }
          }

          private void txtcategoryname_KeyDown(object sender, KeyEventArgs e)
          {
               if (btnsave.Enabled == false)
               {
                    if (e.KeyCode == Keys.Enter)
                    {

                         if (txtcategoryname.Text == "")
                         {
                              MessageBox.Show("PLEASE ENTER AN ITEM TO SEARCH");
                              txtcategoryname.Focus();
                              return;
                         }
                         try
                         {
                              MySqlConnection con = new MySqlConnection(cs.myconnection1);

                              string Query2 = "select category_id,category_name from  letter_category where category_name='" + txtcategoryname.Text + "'  ";
                              con.Open();
                              MySqlCommand mycommand1 = new MySqlCommand(Query2, con);
                              MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                              myadapter.SelectCommand = mycommand1;
                              DataSet ds2 = new DataSet();
                              myadapter.Fill(ds2);
                              int s = (myadapter.Fill(ds2));
                              if (s < 1)
                              {

                                   MessageBox.Show("No such Content", "No such Content in Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                   txtcategoryname.Clear();
                                   txtcategoryname.Focus();
                                   return;

                              }
                              else
                              {

                                   txtcategoryid.Text = ds2.Tables[0].Rows[0][0].ToString();
                                   txtcategoryname.Text = ds2.Tables[0].Rows[0][1].ToString();
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show(ex + "Error while Retreieving the Content Name");
                         }
                         e.Handled = true;
                    }
               }
          }

          private void btncancel_Click(object sender, EventArgs e)
          {
               txtcategoryid.Text = "";
               txtcategoryname.Text = "";
               btnsave.Enabled = true;
               btnupdate.Enabled = false;
          }

          private void btnupdate_Click(object sender, EventArgs e)
          {
               if (txtcategoryname.Text == "")
               {
                    MessageBox.Show("Category Name cannot be empty");
                    return;
               }
               try
               {

                    MySqlConnection conn3 = new MySqlConnection(cs.myconnection1);
                    conn3.Open();
                    string query3 = "update letter_category set category_name='" + txtcategoryname.Text + "'  where category_id='" + Convert.ToInt32(txtcategoryid.Text) + "'";

                    MySqlCommand cmd = new MySqlCommand(query3, conn3);
                    MySqlDataReader myreader1;

                    myreader1 = cmd.ExecuteReader();//execution command
                    conn3.Close();
                    MessageBox.Show("you succefully updated  the Category Details");
                    txtcategoryid.Text = "";
                    txtcategoryname.Text = "";
                    btnsave.Enabled = true;
                    btnupdate.Enabled = false;
                    Application.Exit();
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Database Error");
                    return;
               }
          }

         
         

          private void btnsave2_Click(object sender, EventArgs e)
          {
               //validate
               if(cbocategoryname.Text=="")
               {
                    MessageBox.Show("Please Select The Content Category");
                    return;
               }
               else if (txtcontentsubject.Text=="")
               {
                    MessageBox.Show("Please Insert The content Code");
                    return;
               }
                    else if(txtname.Text=="")
               {
                    MessageBox.Show("Please Enter the Content Name");
                    return;
               }
               else if(cbostatus.Text=="")
               {
                    MessageBox.Show("PLease Indicate The File Status");
                    return;
               }
               else if(txtcontent.Text=="")
               {
                    MessageBox.Show("Please Select a File");
                    return;
               }
               else
               {
             
                    //insert to database
                    try
                    {
                       

                         DateTime datesent = dtpsent.Value;
                         DateTime datereceived = dtpreceived.Value;

                         MySqlConnection myconn1 = new MySqlConnection(cs.myconnection1);
                         myconn1.Open();                     
                         MySqlCommand mycommand1 = new MySqlCommand();
                         mycommand1.Connection = myconn1;
                         mycommand1.CommandText = "insert into  customer_envelope(user_id,category_id,letter_code,Date_sent,date_received,status,filename,file) values('" + Convert.ToInt32(userid.Text) + "',(SELECT category_id FROM letter_category WHERE category_name='" + cbocategoryname.SelectedItem + "'),'" + txtcontentsubject.Text + "','" + datesent.ToString("yyyy-MM-dd HH:mm:ss") + "','" + datereceived.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cbostatus.SelectedItem + "','" + txtname.Text + "','"+txtcontent.Text+"')";
                        
                         mycommand1.ExecuteNonQuery();
                    
                         MessageBox.Show("User Content Saved");
                         clear();
                         myconn1.Close();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex+"Error While Trying to save database");
                         return;
                    }
               }
          }
          private void clear()
          {
               cbocategoryname.SelectedIndex = -1;
               txtcontentsubject.Text = "";
               txtconvertfile.Text = "";
               txtconverted.Text = "";
               cbostatus.SelectedIndex = -1;
               txtcontent.Text = "";
               dtpsent.Value = DateTime.Now;
               dtpreceived.Value = DateTime.Now;
               txtname.Text = "";
          }
          private void button2_Click(object sender, EventArgs e)
          {
               txtconvertfile.Text = "";
               txtconverted.Text = "";
               // open file dialog 
               OpenFileDialog open = new OpenFileDialog();
               // image filters
               open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png;*.bmp)|*.jpg; *.jpeg; *.gif; *.png;*.bmp";
               if (open.ShowDialog() == DialogResult.OK)
               {                   
           
            
                    string testImagePath= Path.GetFullPath(open.FileName);
                    txtconvertfile.Text = testImagePath;

            try
            {  
            
               using (var api = OcrApi.Create())
               {
                    api.Init(Languages.English);
                    string plainText = api.GetTextFromImage(testImagePath);
                    txtconverted.Text= plainText;
               }
         



            }
            catch (Exception ex)
            {          
                 MessageBox.Show("Unexpected Error During Conversion" );
                return;
            }
               }
          }

          private void txtcode_Click(object sender, EventArgs e)
          {
               txtcontentsubject.Text = txtconverted.Text;
               txtcontentsubject.Focus();
          }

          private void btncancel2_Click(object sender, EventArgs e)
          {
               clear();
          }

         
     }
}
