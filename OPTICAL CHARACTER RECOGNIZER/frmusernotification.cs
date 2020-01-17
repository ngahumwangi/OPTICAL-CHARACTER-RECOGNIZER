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
     public partial class frmusernotification : Form
     {
          public frmusernotification()
          {
               InitializeComponent();
          }
          ConnectionString cs = new ConnectionString();
          private void panel3_Paint(object sender, PaintEventArgs e)
          {

          }

          private void btnexit_Click(object sender, EventArgs e)
          {
               //exit
               this.Close();
          }

          private void txtsearch_TextChanged(object sender, EventArgs e)
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
                         dataGridView1.DataSource = dTable;
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("NUll DATA", "STOP!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               }
          }

          private void toolStripMenuItem1_Click(object sender, EventArgs e)
          {
               
               txtid.Text = "";
               txtsubject.Text = "";
               lstmessage.Items.Clear();
               
               //edit dgv content
               if (dataGridView1.Rows.Count < 1)
               {
                    MessageBox.Show("Please Search an Item to Edit");
                    return;
               }
               else
               {
                    try
                    {

                         DataGridViewRow dr = dataGridView1.SelectedRows[0];
                        
                         txtid.Text = dr.Cells[0].Value.ToString();
                          txtsubject.Text = dr.Cells[2].Value.ToString();
                        lstmessage.Items.Add ( "TO:   "+dr.Cells[1].Value.ToString());
                          lstmessage.Items.Add("RECEIVED ON:   "+dr.Cells[5].Value.ToString());
                        lstmessage.Items.Add("STATUS:   " + dr.Cells[4].Value.ToString());
                        lbltitle.Text = "STATUS:   " + dr.Cells[4].Value.ToString();
                        lstmessage.Items.Add("MESSAGE CONTENT");
                        lstmessage.Items.Add(dr.Cells[3].Value.ToString());
                       
                        

                         /********/





                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("SORRY NO DATA!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
          }

          private void btnread_Click(object sender, EventArgs e)
          {
               DataGridViewRow dr = dataGridView1.SelectedRows[0];
               if (dr.Cells[4].Value.ToString()=="UNREAD")
               {

                    try
                    {
                         MySqlConnection myconn2 = new MySqlConnection(cs.myconnection1);
                         myconn2.Open();
                         string query = "update  customer_notification set status='READ' where notification_id='" + Convert.ToInt32(txtid.Text) + "'";

                         MySqlCommand mycommand2 = new MySqlCommand(query, myconn2);

                         mycommand2.ExecuteNonQuery();//execution command
                         MessageBox.Show("Status For This Message has been Updated");
                         this.Close();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show( "Contact Admin");
                         return;
                    }
               }
               else if (dr.Cells[4].Value.ToString() == "READ")
               {
                    MessageBox.Show("This Message Has Already Been Ready");
                    return;
               }
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
     }
}
