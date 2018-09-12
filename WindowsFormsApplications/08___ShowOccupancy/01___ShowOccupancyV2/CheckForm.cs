using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07___
{
    public partial class CheckForm : Form
    {
        
        public const string Busy = "Busy";
        public const string Available = "Available";
        public const string True = "True";

        Test mytest = new Test();
        public CheckForm()
        {
            InitializeComponent();
            checkBox.DataBindings.Add("Checked", mytest, "Condition", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (mytest.Condition == True)
            {
                lblShowOccupancy.Text = Available;
            }
            else
            {
                lblShowOccupancy.Text = Busy;
            }
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {

        }
    }
}
