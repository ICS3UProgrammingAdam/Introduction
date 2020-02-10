using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAppAdam
{
    public partial class frmSchoolApp : Form
    {
        public frmSchoolApp()
        {
            InitializeComponent();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }

        private void FrmSchoolApp_Load(object sender, EventArgs e)
        {

        }
    }
}
