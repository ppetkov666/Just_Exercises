using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15___BindingControlToList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] towns = new string[]
            {
                "Sofia",
                "Plovdiv",
                "Varna",
                "Bourgas",
            };
            ComboBoxTowns.DataSource = towns;
            ComboBoxTowns.DisplayMember = "";
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ComboBoxTowns.SelectedValue.ToString());
        }
    }
}
