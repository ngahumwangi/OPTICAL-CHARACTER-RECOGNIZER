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
    public partial class frmaboutus : Form
    {
        public frmaboutus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutcancel_Click(object sender, EventArgs e)
        {
            // open  the main form and close the Stock form
         
            this.Hide();
           
            this.Close();
        }

      
    }
}
