using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonLoadFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = OpenFileDialog.FileName;
                using (StreamReader reader = File.OpenText(fileName))
                {
                    string fileContent = reader.ReadToEnd();
                    TextBox.Text = fileContent;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
