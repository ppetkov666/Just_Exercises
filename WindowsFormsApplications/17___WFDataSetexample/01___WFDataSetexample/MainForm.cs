namespace _01___WFDataSetexample
{
    using _01___WFDataSetexample.Model;
    using System;
    using System.Data;
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

        private void BShowTownName_Click(object sender, EventArgs e)
        {
            // first step: get the list of tables - in my case is one table towns 
            DataSet townInfoDS = towns.GetTownInfo();
            // second step: extract the table towns from Dataset
            DataTable town = townInfoDS.Tables["Towns"];

            // first way to be done
            DataRow[] row = town.Select();
            foreach (DataRow item in row)
            {
                if (item.Field<int>("id") == int.Parse(TextBoxTowns.Text))
                {
                    tbTextBoxTownName.Text = item.Field<string>("name");
                }
            }

            // second way to be done
            
            //IEnumerable<DataRow> townQuery = from t in town.AsEnumerable() select t;
            //IEnumerable<DataRow> fullInfo = townQuery.Where(p => p.Field<int>("id") == int.Parse(TextBoxTowns.Text));
            //DataRow[] fullinfoAsArray = fullInfo.ToArray();
            //tbTextBoxTownName.Text = fullinfoAsArray[0].Field<string>("name");
        }

        private void TbTextBoxTownName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
