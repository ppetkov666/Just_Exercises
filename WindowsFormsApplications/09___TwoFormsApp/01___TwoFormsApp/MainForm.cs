
namespace _08___
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    public partial class MainForm : Form
    {
        cMyCustomForm customClass = new cMyCustomForm();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void bButtonCallDialog_Click(object sender, EventArgs e)
        {
            cMyCustomForm customForm = new cMyCustomForm();
            if (customForm.ShowDialog() == DialogResult.OK)
            {
                string username = customForm.Username;
                MessageBox.Show("You entered: " + username);
            }
            else
            {
                MessageBox.Show("You canceled the dialog.");
            }
            customForm.Dispose();
        }
    }
}
