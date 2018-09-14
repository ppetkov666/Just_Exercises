
namespace _09___
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
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
        }

        private void fMainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            StringBuilder order = new StringBuilder();
            foreach (var item in CheckedListBoxItems.CheckedItems)
            {
                order.AppendLine(item.ToString());
            }
            order.AppendLine("Shipping Address: ");
            order.AppendLine(TextBoxAddress.Text);
            order.AppendLine("Shipping Method: ");
            if (RadioButtonMail.Checked)
            {
                order.AppendLine("Mail");
            }
            else if (RadioButtonDHL.Checked)
            {
                order.AppendLine("DHL");
            }
            else if (RadioButtonFedEx.Checked)
            {
                order.AppendLine("Fedex");
            }
            order.AppendLine("Track Shipping: ");
            if (CheckBoxTrackShipping.Checked)
            {
                order.AppendLine("YES");
            }
            else
            {
                order.AppendLine("NO");
            }
            MessageBox.Show(order.ToString(), "Info");
        }
    }
}
