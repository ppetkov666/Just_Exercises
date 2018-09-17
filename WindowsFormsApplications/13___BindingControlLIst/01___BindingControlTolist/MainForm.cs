using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14___BindingControlTolist
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
                "Ruse",
                "Stara zagora"
            };
            tbTextBoxTowns.DataBindings.Add("text", towns, "");
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)tbTextBoxTowns.DataBindings["Text"].BindingManagerBase;
            if (cm.Position > 0)
            {
                cm.Position--;
            }
            else
            {
                cm.Position = cm.Count - 1;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)tbTextBoxTowns.DataBindings["Text"].BindingManagerBase;
            if (cm.Position < cm.Count - 1)
            {
                cm.Position++;
            }
            else
            {
                cm.Position = 0;
            }
        }
    }
}
