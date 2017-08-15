using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Akshay Patel
 * 300918514
 * Date: 14th August, 2017
 * Description: Created a calculator.
 * version 0.3 - Created an instance of calculator object.
 */

namespace BMI_Calculator
{
    public static class Program
    {
        // Created form object
        public static Calculator calculator = new Calculator();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
