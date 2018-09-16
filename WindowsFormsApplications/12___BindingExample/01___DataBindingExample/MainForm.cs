using _13___AnotherDataBindingExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___AnotherDataBindingExample
{
    public partial class MainForm : Form
    {
        private Customer mCustomer = new Customer();
        public MainForm()
        {
            InitializeComponent();
            RebindFormControls();
        }


        private void RebindFormControls()
        {
            TextBoxCustomerName.DataBindings.Clear();
            TextBoxCustomerName.DataBindings.Add(
            new Binding("Text", mCustomer, "Name"));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            mCustomer.Name = "Default Name";
            RebindFormControls();
        }

        private void ButtonShowCustomer_Click(object sender, EventArgs e)
        {
            string customerName = mCustomer.Name;
            MessageBox.Show(customerName);
        }

        private void ButtonChangeCustomer_Click(object sender, EventArgs e)
        {
            mCustomer.Name = "Name was Changed";
        }

        private void ButtonRebind_Click(object sender, EventArgs e)
        {
            RebindFormControls();
        }
    }
}
