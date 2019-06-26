
namespace CoffeeApp
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
    partial class f_main_form : Form
    {
        public DataGridView dgw_table;
        private List<TextBox> textBoxList;
        private List<Label> labelList;
        private Button b_submit_user_name;
        private Button b_submit_drink;
        private ListBox list_box_result;
        private static int AddUserNumOfFields = 2;
        private static int AddDrinkNumOfFields = 2;
        List<Person> people = new List<Person>();
        List<Drink> drinks = new List<Drink>();

        public f_main_form()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetBindedInfoFromDB();
        }
        private void b_add_user_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayTextBoxesAndLabels("First Name", "Last Name", AddUserNumOfFields);
            b_submit_user_name = CreateDynamicControl(b_submit_user_name, "b_submit_user_name");
            b_submit_user_name.Click += B_submit_user_name_Click;
            DisplayPnl.Controls.Add(b_submit_user_name);
        }
        private void b_add_drink_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayTextBoxesAndLabels("Drink Name", "Price", AddDrinkNumOfFields);
            b_submit_drink = CreateDynamicControl(b_submit_drink, "b_submit_drink");
            b_submit_drink.Click += B_submit_drink_Click;
            DisplayPnl.Controls.Add(b_submit_drink);
        }
        private void b_return_to_main_page_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            GetBindedInfoFromDB();
            DisplayPnl.Controls.Add(lbl_quantity);
            DisplayPnl.Controls.Add(lbl_choose_drink);
            DisplayPnl.Controls.Add(llb_choose_user);
            DisplayPnl.Controls.Add(cb_users);
            DisplayPnl.Controls.Add(cb_drinks);
            DisplayPnl.Controls.Add(cb_quantity);
            DisplayPnl.Controls.Add(b_submit);
        }
        private void b_custom_report_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();

            DisplayPnl.Controls.Add(llb_choose_user);
            DisplayPnl.Controls.Add(cb_users);
            // to be continue
           list_box_result = new ListBox();
           list_box_result.FormattingEnabled = true;
           list_box_result.ItemHeight = 25;
           list_box_result.Location = new System.Drawing.Point(12, 65);
           list_box_result.Name = "list_box_result";
           list_box_result.Size = new System.Drawing.Size(700, 200);
           list_box_result.TabIndex = 0;
           DisplayPnl.Controls.Add(list_box_result);
        }
        private void b_report_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            CreateDataGridView();
            DataAcccess db = new DataAcccess();
            dgw_table.DataSource = db.GetDataSet();
        }
        private void b_submit_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            db.InsertIntoDB(cb_users.Text, cb_drinks.Text, int.Parse(cb_quantity.Text));
            MessageBox.Show($"{cb_drinks.Text} with quantity {cb_quantity.Text} has been added to {cb_users.Text} account");
        }
        private void B_submit_user_name_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            db.InsertUserIntoDB(textBoxList[0].Text, textBoxList[1].Text);
            MessageBox.Show($"{textBoxList[0].Text} {textBoxList[1].Text} was added !");

        }
        private void B_submit_drink_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            db.InsertDrinks(textBoxList[0].Text, double.Parse(textBoxList[1].Text));
            MessageBox.Show($"{textBoxList[0].Text} with price {textBoxList[1].Text} was added !");
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
        private void CreateDataGridView()
        {
            dgw_table = new DataGridView();
            ((ISupportInitialize)(dgw_table)).BeginInit();
            dgw_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_table.Location = new Point(12, 40);
            dgw_table.Name = "dataGridView1";
            dgw_table.Size = new Size(640, 150);
            dgw_table.TabIndex = 0;
            DisplayPnl.Controls.Add(dgw_table);
            ((ISupportInitialize)(dgw_table)).EndInit();
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
        private Button CreateDynamicControl(Button button, string name)
        {
            button = new Button();
            button.Location = new Point(240, 100);
            button.Name = name;
            button.Size = new Size(150, 23);
            button.TabIndex = 6;
            button.Text = "Submit";
            button.UseVisualStyleBackColor = true;
            return button;
        }
        private void UpdateBinding()
        {
            cb_users.DataSource = people;
            cb_users.DisplayMember = "FullName";
            cb_drinks.DataSource = drinks;
            cb_drinks.DisplayMember = "DrinkName";
        }
        private void GetBindedInfoFromDB()
        {
            DataAcccess db = new DataAcccess();
            people = db.GetPeople();
            drinks = db.GetDrinks();
            UpdateBinding();
        }
    }
}
