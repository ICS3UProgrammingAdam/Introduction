using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolAdam
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void BtnPerimiter_Click(object sender, EventArgs e)
        {
            //calculate the perimiter of the rectangle
            this.lblPerimiter.Text = Convert.ToString(2 * 12 + 2 * 4) + "cm";
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            //Calculate the area of a circle
            this.lblArea.Text = Convert.ToString(Math.PI* Math.Pow(6, 2)) + "km";
        }

        private void BtnVolume_Click(object sender, EventArgs e)
        {
            //calculate the volume of a sphere
            this.lblVolume.Text = Convert.ToString((double)4/(double)3 * Math.PI * Math.Pow(25, 3)) + "m";

        }

        private void FrmPerAreaVol_Load(object sender, EventArgs e)
        {

        }
    }
}
