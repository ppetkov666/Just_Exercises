using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalculator
{
    public partial class Calculator : Form
    {
        
        public Calculator()
        {
            InitializeComponent();   
        }

        private void button1Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal firstNumber = decimal.Parse(textBox1.Text);
                decimal secondNumber = decimal.Parse(textBox2.Text);
                decimal sum = firstNumber + secondNumber;
                textBoxSum.Text = sum.ToString();
            }
            catch (Exception)
            {

                textBoxSum.Text = "Enter Only Numbers";
            }
        }
    }
}
