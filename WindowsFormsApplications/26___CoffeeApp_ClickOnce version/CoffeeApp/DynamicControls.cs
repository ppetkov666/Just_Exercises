using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    static class DynamicControls
    {
        public static ListBox CreateListBox(ListBox listbox)
        {
            listbox = new ListBox();
            listbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 30;
            listbox.Name = "list_box_result";
            listbox.Size = new Size(700, 150);
            listbox.Location = new Point(12, 100);
            listbox.TabIndex = 0;
            return listbox;
        }

        public static DataGridView CreateDataGridView(DataGridView datagridview)
        {
            datagridview = new DataGridView();
            ((ISupportInitialize)(datagridview)).BeginInit();
            datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(12, 40);
            datagridview.Name = "dataGridView1";
            datagridview.Size = new Size(640, 150);
            datagridview.TabIndex = 0;
            ((ISupportInitialize)(datagridview)).EndInit();
            return datagridview;
        }
        public static Label CreateLabelPrint(Label label, Person user, ComboBox comboBox)
        {
            label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(12, 80);
            label.Name = "lbl_quantity";
            label.Size = new Size(46, 20);
            label.TabIndex = 2;
            if (user.TotalMoneyToBePaid == 0)
            {
                label.BackColor = Color.Aqua;
                label.Text = $"{comboBox.Text} has nothing to pay!";
            }
            else
            {
                label.BackColor = Color.LightCoral;
                label.Text = $"{comboBox.Text} must pay {user.TotalMoneyToBePaid:f2} leva.For Additional info check the list below";
            }
            return label;
        }
        public static Label CreateLabel(string param, int index)
        {
            Label label = new Label();
            label.Text = param;
            label.Location = new Point(20, 10 + (index * 30));
            label.Size = new Size(100, 30);
            return label;
        }
        public static TextBox CreateTextBox(int index)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(120, 10 + (index * 30));
            textBox.Size = new Size(270, 30);
            return textBox;
        }
        public static Button CreateButton(Button button, string name, int x, int y)
        {
            button = new Button();
            button.Location = new Point(x, y);
            button.Name = name;
            button.Size = new Size(150, 28);
            button.TabIndex = 6;
            button.Text = "Submit";
            button.UseVisualStyleBackColor = true;
            return button;
        }
    }
}
