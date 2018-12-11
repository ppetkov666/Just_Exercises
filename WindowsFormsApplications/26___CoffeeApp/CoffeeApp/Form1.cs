using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    partial class f_main_form : Form
    {
        private List<TextBox> textBoxList;
        private List<Label> labelList;
        private List<ComboBox> comboBoxList;
        private static int AddUserNumOfFields = 2;
        private static int AddDrinkNumOfFields = 2;
        private static int ReturnNumOfFields = 3;
        List<Person> people = new List<Person>();
        List<Drink> drinks = new List<Drink>();
        private System.Windows.Forms.DataGridView dataGridView1;

        public f_main_form()
        {
            InitializeComponent();
        }

        private void b_add_user_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            
            DisplayTextBoxesAndLabels("First Name", "Last Name", AddUserNumOfFields);
        }
        private void b_add_drink_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayTextBoxesAndLabels("Drink Name", "Price", AddDrinkNumOfFields);
        }
        private void b_return_to_main_page_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayComboBoxesAndLabels("Choose User Name", "Drink Type", "Quantity",ReturnNumOfFields);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            people = db.GetPeople();
            drinks = db.GetDrinks();
            UpdateBinding();
        }
        public void DisplayTextBoxesAndLabels(string firstLabelText, string secondLabelText, int numOfFields)
        {

            textBoxList = new List<TextBox>();
            labelList = new List<Label>();


            for (int i = 1; i <= numOfFields; i++)
            {

                if (i == 1)
                {
                    labelList.Add(CreateLabel(firstLabelText, i));
                    textBoxList.Add(CreateTextBox(i));
                }
                else if (i == 2)
                {
                    labelList.Add(CreateLabel(secondLabelText, i));
                    textBoxList.Add(CreateTextBox(i));
                }
            }

            for (int i = 0; i < textBoxList.Count; i++)
            {
                this.DisplayPnl.Controls.Add(textBoxList[i]);
                this.DisplayPnl.Controls.Add(labelList[i]);
            }
        }
        public void DisplayComboBoxesAndLabels(string firstLabelText, string secondLabelText,string thirdLabelText, int numOfFields)
        {

            comboBoxList = new List<ComboBox>();
            labelList = new List<Label>();
            DataAcccess db = new DataAcccess();

            for (int i = 1; i <= numOfFields; i++)
            {

                if (i == 1)
                {
                    labelList.Add(CreateLabel(firstLabelText, i));
                    comboBoxList.Add(CreateComboBox(i));
                    people = db.GetPeople();
                    comboBoxList[0].DataSource = people;
                    comboBoxList[0].DisplayMember = "FullName";

                }
                else if (i == 2)
                {
                    labelList.Add(CreateLabel(secondLabelText, i));
                    comboBoxList.Add(CreateComboBox(i));
                    drinks = db.GetDrinks();
                    comboBoxList[1].DataSource = drinks;
                    comboBoxList[1].DisplayMember = "DrinkName";
                }
                else if (i == 3)
                {
                    labelList.Add(CreateLabel(thirdLabelText, i));
                    comboBoxList.Add(CreateComboBox(i));
                    for (int y = 1; y <= 30; y++)
                    {
                        comboBoxList[2].Items.Add(y);
                    }
                }
            }

            for (int i = 0; i < comboBoxList.Count; i++)
            {
                this.DisplayPnl.Controls.Add(comboBoxList[i]);
                this.DisplayPnl.Controls.Add(labelList[i]);
            }
        }
        private Label CreateLabel(string param, int index)
        {
            Label dynamicLabel = new Label();
            dynamicLabel.Text = param;
            dynamicLabel.Location = new Point(20, 10 + (index * 30));
            dynamicLabel.Size = new Size(100, 30);
            return dynamicLabel;
        }
        private TextBox CreateTextBox(int index)
        {
            TextBox dynamicTextBox = new TextBox();
            dynamicTextBox.Location = new Point(120, 10 + (index * 30));
            dynamicTextBox.Size = new Size(270, 30);
            return dynamicTextBox;
        }
        private ComboBox CreateComboBox(int index)
        {
            ComboBox dynamicComboBox = new ComboBox();
            dynamicComboBox.Location = new Point(120, 10 + (index * 30));
            dynamicComboBox.Size = new Size(270, 30);
            return dynamicComboBox;
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            db.InsertIntoDB(cb_users.Text, cb_drinks.Text, int.Parse(cb_quantity.Text));
        }
        private void UpdateBinding()
        {
            cb_users.DataSource = people;
            cb_users.DisplayMember = "FullName";
            cb_drinks.DataSource = drinks;
            cb_drinks.DisplayMember = "DrinkName";
        }

        private void b_report_Click(object sender, EventArgs e)
        {
          // DisplayPnl.Controls.Clear();
          // this.dataGridView1 = new DataGridView();
          // ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
          // this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          // this.dataGridView1.Location = new Point(12, 61);
          // this.dataGridView1.Name = "dataGridView1";
          // this.dataGridView1.Size = new Size(468, 228);
          // this.dataGridView1.TabIndex = 0;
          // this.Controls.Add(this.dataGridView1);
          // ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
          // DataAcccess db = new DataAcccess();
          // dataGridView1.DataSource = db.GetDataSet();
        }
    }
}
