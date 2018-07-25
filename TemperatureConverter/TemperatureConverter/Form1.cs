/*----------------My Tempereatur Converter----------------------
 Here is my Temperature convereter for my Programming Assignment from "Celsius to Fahrenheit"*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        // Exit Button

        private void button3_Click(object sender, EventArgs e) // Exit button to "exit the form
        {
            Close();
        }

        // Clear Button

        private void btnCLEAR_Click(object sender, EventArgs e) // Clear button to clear "input and output" 
        {
            txtCELSIUS.ResetText();                             // I used this method to clear the contents in the input and output text boxes back to default 
            txtFAHRENHEIT.ResetText();
        }
         
        // Convert Button and Code

        private void btnCONVERT_Click(object sender, EventArgs e) // My "convert" programming
        {
            double celsius = 0;                                     // I used a double precision floating point for my variables                                     
            double fahrenheit = 32;

            double.TryParse(txtCELSIUS.Text, out celsius);          // I used the double "TryParse" method to convert the double precision floating point values.
            fahrenheit = (celsius * 1.8) + 32;                      // This is the calculation of the coversion formula I used to acheive the final results.
            txtFAHRENHEIT.Text = fahrenheit.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
