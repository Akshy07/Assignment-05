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
 * Description: Created a calculator.
 * version 0.2 - Added FormClosing event handler.
 */

namespace BMI_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is an event handler for "Form Closing".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
