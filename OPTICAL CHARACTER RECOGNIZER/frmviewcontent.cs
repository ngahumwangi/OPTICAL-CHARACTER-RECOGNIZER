using MySql.Data.MySqlClient;
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
     public partial class frmviewcontent : Form
     {
          public frmviewcontent()
          {
               InitializeComponent();
          }
          ConnectionString cs = new ConnectionString();
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
                              string query = "select category_id As CONTENT_CATEGORY,letter_code AS SUBJECT,Date_sent AS SENT_ON,date_received AS RECEIVED_ON,status AS STATUS,file AS CONTENT FROM customer_envelope where letter_code like'%" + txtsearch.Text.ToUpper() + "%' or user_id like'%" + txtsearch.Text.ToUpper() + "%' order by date_received DESC";

                              MySqlCommand mycommand1 = new MySqlCommand(query, myconn1);

                              MySqlDataAdapter myadapter = new MySqlDataAdapter();//for offline connection we use mysqldataadapter
                              myadapter.SelectCommand = mycommand1;
                              DataTable dTable = new DataTable();
                              myadapter.Fill(dTable);
                              dgvsearch.DataSource = dTable;
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("NUll DATA", "STOP!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
               }
          }

          private void mnget_Click(object sender, EventArgs e)
          {
               //open the content
               if (dgvsearch.Rows.Count < 1)
               {
                    MessageBox.Show("Please Search an Item to Edit");
                    return;
               }
               else
               {
                    try
                    {

                         DataGridViewRow dr = dgvsearch.SelectedRows[0];

                         listBox1.Items.Add("CATEGORY ID           "+dr.Cells[0].Value.ToString());
                         listBox1.Items.Add("THE CONTENT SUBJECT:  "+dr.Cells[1].Value.ToString());
                         txtcode.Text = dr.Cells[1].Value.ToString();
                          listBox1.Items.Add("SENT ON:             "+dr.Cells[2].Value.ToString());
                         listBox1.Items.Add("RECEIVED ON:          " + dr.Cells[3].Value.ToString());
                        listBox1.Items.Add("STATUS:                " + dr.Cells[4].Value.ToString());
                        listBox1.Items.Add("CONTENT");
                        listBox1.Items.Add(dr.Cells[5].Value.ToString());


                         
                        tabControl1.SelectedTab = tabPage2;
                        



                         /********/





                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("SORRY NO DATA!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

               }

          }

          private void btnupdate_Click(object sender, EventArgs e)
          {

                    try
                    {
                         MySqlConnection myconn2 = new MySqlConnection(cs.myconnection1);
                         myconn2.Open();
                         string query = "update  customer_envelope set status='SEEN' where 	letter_code='" + txtcode.Text + "'";

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
              
          }

          

}     
         
   