

namespace BindingDataWindowsFormsApp
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
    using BindingDataWindowsFormsApp.Models;
    public partial class FrmLocation : Form
    {
        cLocation cLocation = new cLocation();
       
        public FrmLocation()
        {
            InitializeComponent();

            //chkOccupancyBox.DataBindings.Add("Checked", cLocation, "LocationOccupancy", true,  DataSourceUpdateMode.OnPropertyChanged);
            chkOccupancyBox.DataBindings.Add("CheckState", cLocation, "LocationOccupancy", true, DataSourceUpdateMode.OnPropertyChanged);
            lblOccupancyNameBox.DataBindings.Add("Text", cLocation, "OccupancyName", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {

        }
    }
}
