


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
            DataAccess db = new DataAccess();
            db.ChangeState();
            Boolean istrue = db.GetState();
            cc.Active = istrue;
            bButtonClick.DataBindings.Add("visible", cc, "Active");
        }
    }
}
