
/*
 * Created by: Adam Meskini
 * Created on: Feb, 11, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello, World! international
 * This program displays radio buttons that is named different languages and when the 
 * radio button is clicked it translate the title (Hello World) 
 * to its assigned language
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellointAdam
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void LblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            //Changed the greeting to french
            this.lblGreeting.Text = "Bonjour le monde!";
           
           

        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //changes greeting to english
            this.lblGreeting.Text = "Hello, World!" +
                "";
        }

        private void RadVietnamese_CheckedChanged(object sender, EventArgs e)
        {
            //changes greeting to vietnamese
            this.lblGreeting.Text = "Chào thế giới!" +
                "";
        }

        private void RadArabic_CheckedChanged(object sender, EventArgs e)
        {
            //changes greeting to german
            this.lblGreeting.Text = "Hallo Welt!";

        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
