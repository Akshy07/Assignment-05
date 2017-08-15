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

        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            HeightBox.Text = "m";
            WeightBox.Text = "kgs";
        }
        /// <summary>
        /// This event changes the units to imperial units.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Imperical_CheckedChanged(object sender, EventArgs e)
        {
            HeightBox.Text = "inches";
            WeightBox.Text = "pounds";
        }
        /// <summary>
        /// This is an event handler for "Form Closing".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (Imperial.Checked == true)
            {
                double height = double.Parse(HeightBox.Text);
                double Weight = double.Parse(WeightBox.Text);
                double BMI;
                BMI = (Weight * 703) / (height * height);
                ResultBox.Text = BMI.ToString();
                
            }
            if (Metric.Checked == true)
            {
                double height = double.Parse(HeightBox.Text);
                double Weight = double.Parse(WeightBox.Text);
                double BMI;
                BMI = (Weight) / (height * height);
                ResultBox.Text = BMI.ToString();

            }
         }

        private void HeightText_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this events modifies height textbox to accept only numbers and backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputHeight = e.KeyChar;
            if (!char.IsDigit(inputHeight) && inputHeight != 8 && inputHeight != 46)
            {
                e.Handled = true;
            }
        }
        private void WeightText_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This event modifies the weight textbox to only accept numbers and backspace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputWeight = e.KeyChar;
            if (!char.IsDigit(inputWeight) && inputWeight != 8 && inputWeight != 46)
            {
                e.Handled = true;
            }
        }
    }
}

