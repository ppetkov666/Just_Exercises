
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
    
    public partial class cMyCustomForm : Form,INotifyPropertyChanged
    {
        public cMyCustomForm()
        {
            InitializeComponent();
            
        }
        public string Username
        {
            get
            {
                return tbTextBox.Text;
            }
            set
            {
                if (value == tbTextBox.Text)
                {
                    return;
                }
                tbTextBox.Text = value;
                OnPropertyChanged("tbTextBox");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            bool confirmed = MessageBox.Show("Are you sure ?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (confirmed)
            {
                tbTextBox.Text = string.Empty;
                MessageBox.Show("The record was Deleted");
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
           MessageBox.Show($"{bOk.Text} was clicked !", "Warning!!!");
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{bCancel.Text} was clicked !", "Warning!!!");
        }

        private void bSetDefaultValue_Click(object sender, EventArgs e)
        {
            tbTextBox.Text = "Default";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
