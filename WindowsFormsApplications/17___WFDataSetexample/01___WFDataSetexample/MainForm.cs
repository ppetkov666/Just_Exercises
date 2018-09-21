

namespace _12___SimpleDataBindingExample
{
    using _12___SimpleDataBindingExample.Model;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        TownInfo towns = new TownInfo();
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            TextBoxTowns.DataBindings.Add("Text", towns.GetTownInfo(), "Towns.id");
        }

        private void bShowTownName_Click(object sender, EventArgs e)
        {
            // first step: get the list of tables - in my case is one table towns 
            DataSet townInfoDS = towns.GetTownInfo();
            // second step: extract the table towns from Dataset
            DataTable town = townInfoDS.Tables["Towns"];
            // third step: get it as Enumerable to be able to use LINQ
            IEnumerable<DataRow> townQuery = from t in town.AsEnumerable() select t;
            // fourth step: get exactly the town i want  using LINQ
            IEnumerable<DataRow> fullInfo = townQuery.Where(p => p.Field<int>("id") == int.Parse(TextBoxTowns.Text));
            // last step: get the name of this town
            foreach (var item in fullInfo)
            {
                tbTextBoxTownName.Text = item.Field<string>("name");
            }
        }

        private void tbTextBoxTownName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
