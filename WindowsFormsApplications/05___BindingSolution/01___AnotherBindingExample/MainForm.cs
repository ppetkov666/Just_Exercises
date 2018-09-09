

namespace _03___AnotherBindingExample
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
    public partial class CheckForm : Form
    {

        public CheckForm()
        {
            InitializeComponent();

            //data source
            Binding binding = new Binding("Text", textBox2, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            // data target
            // the goal is whatever is written in textBox1 to be updated on textBox2
            textBox1.DataBindings.Add(binding);
            // this could be written on One Row also 
            //textBox1.DataBindings.Add("Text", textBox2, "text", true, DataSourceUpdateMode.OnPropertyChanged);

            // the second interesting thing is :
            this.DataBindings.Add("Size", textBox2, "Text", true, DataSourceUpdateMode.OnPropertyChanged);

            //
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {

        }
    }
}
