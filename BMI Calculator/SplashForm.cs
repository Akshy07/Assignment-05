using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Akshay Patel
 * 300918514
 * Date: 14th August, 2017
 * Description: This is a splash form.
 * version 0.3 - refactored the Splashform timer control.
 */

namespace BMI_Calculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        
        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handler for the "TICK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashformTimer_Tick(object sender, EventArgs e)
        {
            
            Program.calculator.Show();
            this.Hide();
            SplashformTimer.Enabled = false;
        }
    }
}
