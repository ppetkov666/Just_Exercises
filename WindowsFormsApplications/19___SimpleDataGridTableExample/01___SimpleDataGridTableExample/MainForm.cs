using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16___DataGrid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create table "Towns"
            DataTable towns = new DataTable("Towns");
            towns.Columns.Add(new DataColumn("id", typeof(int)));
            towns.Columns.Add(new DataColumn("name", typeof(string)));
            // Add some rows in the table
            DataRow row = towns.NewRow();
            row["id"] = 1;
            row["name"] = "София";
            towns.Rows.Add(row);
            row = towns.NewRow();
            row["id"] = 2;
            row["name"] = "Пловдив";
            towns.Rows.Add(row);
            row = towns.NewRow();
            row["id"] = 3;
            row["name"] = "Варна";
            towns.Rows.Add(row);
            row = towns.NewRow();
            row["id"] = 4; 
            row["name"] = "Русе";
            towns.Rows.Add(row);
            row = towns.NewRow();
            row["id"] = 5;
            row["name"] = "Stara Zagora";
            towns.Rows.Add(row);
            // Add table "Towns" to the DataSet
            DataSet ds = new DataSet();
            ds.Tables.Add(towns);
            // Bind the DataGrid to the DataSet
            DataGridTowns.DataSource = ds;
            DataGridTowns.DataMember = "Towns";
        }
    }
}
