using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17___
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petkoTestDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.petkoTestDBDataSet.Employees);

        }
    }
}
