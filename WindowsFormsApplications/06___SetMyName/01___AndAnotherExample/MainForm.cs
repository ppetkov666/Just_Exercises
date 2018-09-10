using _04___AndAnotherExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04___AndAnotherExample
{
    public partial class CheckForm : Form
    {
        private Person person = new Person();
        public CheckForm()
        {
            InitializeComponent();

            // it binds the text of the controller to the Name property of the clas Person
            // dataSource  - person  is the class (its instance) and datasource member it is the property ot class person 
            // in this case textbox1 is the data target and person is the data source
           tbInputData.DataBindings.Add("Text", person, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void SetMyNameButton_Click(object sender, EventArgs e)
        {
            person.Name = "Hello";
        }

        private void ShowMyNameButton_Click(object sender, EventArgs e)
        {
            this.Text = person.Name;
        }

        private void PrintMyNamelabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.Name.Trim());
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {

        }
    }
}
