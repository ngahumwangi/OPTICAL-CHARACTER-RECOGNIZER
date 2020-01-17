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
    public partial class frmdatabaseback : Form
    {
        public frmdatabaseback()
        {
            InitializeComponent();
        }
        ConnectionString cs = new ConnectionString();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                btnbackup.Visible = false;
                SaveFileDialog savefile = new SaveFileDialog();
                // set a default file name
                savefile.FileName = "OcrBackUp.sql";
                savefile.Filter = "SQL  FILES|*.sql";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                     
                    using (MySqlConnection conn = new MySqlConnection(cs.myconnection1))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportInfo.AddCreateDatabase = true;
                                mb.ExportToFile(savefile.FileName);
                                conn.Close();
                            }
                        }
                    }

                }

                //backup the database


                MessageBox.Show("OPERATION COMPLETE");
                btnbackup.Visible = true;

            }
            catch
            {

            }
        }

   

        

        private void button1_Click_1(object sender, EventArgs e)
        {
             try
             {

                  OpenFileDialog open = new OpenFileDialog();

                  // set a default file name
                  open.FileName = "OcrBackUp.sql";
                  open.Filter = "SQL  FILES|*.sql";
                  if (open.ShowDialog() == DialogResult.OK)
                  {
                       using (MySqlConnection conn = new MySqlConnection(cs.myconnection1))
                       {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                 using (MySqlBackup mb = new MySqlBackup(cmd))
                                 {
                                      cmd.Connection = conn;
                                      conn.Open();
                                      mb.ImportInfo.TargetDatabase = "db_ocr";
                                      mb.ImportFromFile(open.FileName);
                                 }
                            }
                       }
                  }
                  MessageBox.Show("OPERATION COMPLETE");

             }
             catch (Exception ex)
             {
                  MessageBox.Show(ex.Message);
             }
        }
    }
}
