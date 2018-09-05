using DBFirstApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstApp
{
    public partial class fUserInterface : Form
    {
        
        public fUserInterface()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
          try
          {
              int idNumber = int.Parse(tbId.Text);
              MyDataBaseSampleEntities myDatabase = new MyDataBaseSampleEntities();
              UserInfo ExtractedInfo = myDatabase.UserInfoes.Where(a => a.Id == idNumber).SingleOrDefault();
              tbUserName.Text = ExtractedInfo.UserName;
              tbPassword.Text = ExtractedInfo.Password;
              tbEmail.Text = ExtractedInfo.Email;
              tbAddress.Text = ExtractedInfo.Address;
              tbTown.Text = ExtractedInfo.Town;
          }
          catch (Exception)
          {
          
              MessageBox.Show("There is no Information for user with this ID");
          }
            
        }

        private void fUserInterface_Load(object sender, EventArgs e)
        {

        }
    }

}
