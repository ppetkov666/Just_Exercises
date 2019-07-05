


namespace _01___WFDinamicallyCreatedButtons
{
    using _01___WFDinamicallyCreatedButtons.Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        CustomControl cc = new CustomControl();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // the main purpose of this small program is to set the field to 1 - active and the to visualize the button click
            // it is done because of test purposes !
            DataAccess db = new DataAccess();
            Boolean istrue = db.GetState();
            cc.Active = istrue;
            b_status.DataBindings.Add("visible", cc, "Active");

        }

        private void bButtonClick_Click(object sender, EventArgs e)
        {
            string text = text_box.Text;
            if (text == "active" || text =="hide")
            {
                b_status.DataBindings.Clear();
                DataAccess db = new DataAccess();
                db.ChangeState(text);
                Boolean istrue = db.GetState();
                cc.Active = istrue;
                b_status.DataBindings.Add("visible", cc, "Active");
            }
        }
    }
}
