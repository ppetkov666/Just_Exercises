
namespace AdoConnectionApp
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
    using AdoConnectionApp.Model;
    public partial class DashBoard : Form
    {
        List<Person> people = new List<Person>();
        public DashBoard()
        {
            InitializeComponent();
           
        }
        private void UpdateBinding()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
            
            

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            people = db.GetPeople(tblastName.Text);
            UpdateBinding();

        }
        private void ClearButtons(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        private void bInsertData_Click(object sender, EventArgs e)
        {
            DataAcccess mydata = new DataAcccess();
            mydata.InsertIntoDB(tbFirstNameInsert.Text, tbLastNameInsert.Text, tbAgeInsert.Text, tbCountryInsert.Text);
            ClearButtons(tbFirstNameInsert, tbLastNameInsert, tbAgeInsert, tbCountryInsert);
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
