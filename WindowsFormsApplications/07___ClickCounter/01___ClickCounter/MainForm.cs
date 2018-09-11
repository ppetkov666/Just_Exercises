using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CheckForm : Form
    {
        public int count = 0;
        public CheckForm()
        {
            InitializeComponent();
        }

        private void SetMyNameButton_Click(object sender, EventArgs e)
        {
            count++;

        }

        private void ShowMyNameButton_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Click on the Button Click");
            }
            else
            {
                MessageBox.Show(count.ToString());
            }
           
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            count = 0;
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {

        }
    }
}
