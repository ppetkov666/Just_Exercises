
namespace CoffeeApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    partial class f_main_form : Form
    {
        private DataGridView dgw_table;
        private List<TextBox> textBoxList;
        private List<Label> labelList;
        private Person user;
        private Button b_submit_user_name;
        private Button b_submit_drink;
        private Button b_submit_custom_info;
        private Label lbl_custom_report;
        private ListBox list_box_result;
        private static int mAddUserNumOfFields = 2;
        private static int mAddDrinkNumOfFields = 2;
        private const string cErrorMessage = "Error Message!";
        private const string cInformationMessage = "Information Message!";
        private List<Person> people = new List<Person>();
        private List<Drink> drinks = new List<Drink>();
        private List<Drink> drinkInfo = new List<Drink>();

        public f_main_form()
        {
            InitializeComponent();
        }
        private void Main_form_load(object sender, EventArgs e)
        {
            GetBindedInfoFromDB();
        }
        private void b_add_user_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayTextBoxesAndLabels("First Name", "Last Name", mAddUserNumOfFields);
            b_submit_user_name = CreateDynamicControl(b_submit_user_name, "b_submit_user_name", 240, 100);
            b_submit_user_name.Click += B_submit_user_name_Click;
            DisplayPnl.Controls.Add(b_submit_user_name);
        }
        private void b_add_drink_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayTextBoxesAndLabels("Drink Name", "Price", mAddDrinkNumOfFields);
            b_submit_drink = CreateDynamicControl(b_submit_drink, "b_submit_drink", 240, 100);
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
            // create dynamically listbox
           

            // create dynamically button
            b_submit_custom_info = CreateDynamicControl(b_submit_custom_info, "b_submit_custom_info", 562, 40);
            b_submit_custom_info.Click += B_submit_custom_info_Click;
            // add it to Panel 
            DisplayPnl.Controls.Add(llb_choose_user);
            DisplayPnl.Controls.Add(cb_users);
            // here i will demonstate the second way as passing directly the method into DisplayPnl
            DisplayPnl.Controls.Add(CreateListBox(list_box_result));
            DisplayPnl.Controls.Add(b_submit_custom_info);
        }

        private ListBox CreateListBox(ListBox listbox)
        {
            list_box_result = new ListBox();
            list_box_result.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            list_box_result.FormattingEnabled = true;
            list_box_result.ItemHeight = 30;
            list_box_result.Name = "list_box_result";
            list_box_result.Size = new Size(700, 150);
            list_box_result.Location = new Point(12, 100);
            list_box_result.TabIndex = 0;
            return list_box_result;
        }

        private void b_report_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            CreateDataGridView();
            DataAcccess db = new DataAcccess();
            dgw_table.DataSource = db.GetDataSet();
        }
        private void B_submit_custom_info_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Remove(lbl_custom_report);

            string[] splitName = cb_users.Text.Split().ToArray();
            DataAcccess db = new DataAcccess();
            drinkInfo = db.GetCustomPerson(splitName[0], splitName[1]);
            user = new Person();
            foreach (var drink in drinkInfo)
            {
                user.TotalMoneyToBePaid += drink.Total;
            }
            list_box_result.DataSource = drinkInfo;
            list_box_result.DisplayMember = "DetailedInfo";

            // create dynamically label - i use method and then a variable , or it can be passed directly to the DisplayPnl because it returns the label itself
            lbl_custom_report = CreateLabel(lbl_custom_report, user);
            DisplayPnl.Controls.Add(lbl_custom_report);
        }

        private Label CreateLabel(Label label, Person user)
        {
            lbl_custom_report = new Label();
            lbl_custom_report.AutoSize = true;
            lbl_custom_report.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_custom_report.Location = new Point(12, 80);
            lbl_custom_report.Name = "lbl_quantity";
            lbl_custom_report.Size = new Size(46, 13);
            lbl_custom_report.TabIndex = 2;
            if (user.TotalMoneyToBePaid == 0)
            {
                lbl_custom_report.BackColor = Color.Aqua;
                lbl_custom_report.Text = $"{cb_users.Text} has nothing to pay!";
            }
            else
            {
                lbl_custom_report.BackColor = Color.LightCoral;
                lbl_custom_report.Text = $"{cb_users.Text} must pay {user.TotalMoneyToBePaid:f2} leva.For Additional info check the list below";
            }
            return lbl_custom_report;
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            db.InsertIntoDB(cb_users.Text, cb_drinks.Text, int.Parse(cb_quantity.Text));
            Display($"{cb_drinks.Text} with quantity {cb_quantity.Text} has been added to {cb_users.Text} account", cInformationMessage, MessageBoxIcon.Information);
        }
        private void B_submit_user_name_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();

            if (!Regex.IsMatch(textBoxList[0].Text, @"^[a-zA-Z]+$") ||
                !Regex.IsMatch(textBoxList[1].Text, @"^[a-zA-Z]+$"))
            {
                Display("First or Last name must be consisted of letters only",cErrorMessage,MessageBoxIcon.Error);
            }
            else if ((textBoxList[0].Text.Length < 2 || textBoxList[0].Text.Length > 20) &&
                (textBoxList[1].Text.Length < 2 || textBoxList[1].Text.Length > 20))
            {
                Display("First and Last name must be between 2 and 20 symbols long",cErrorMessage,MessageBoxIcon.Error);
            }
            else
            {
                db.InsertUserIntoDB(textBoxList[0].Text, textBoxList[1].Text);
                Display($"{textBoxList[0].Text} {textBoxList[1].Text} was added !", cInformationMessage, MessageBoxIcon.Information);
            }
        }
        private void B_submit_drink_Click(object sender, EventArgs e)
        {
            DataAcccess db = new DataAcccess();
            double parsedInput;
            if (double.TryParse(textBoxList[1].Text, out parsedInput)
                && (parsedInput > 0)
                && (textBoxList[0].Text.Length >= 5 && textBoxList[0].Text.Length <= 20))
            {
                db.InsertDrinks(textBoxList[0].Text, parsedInput);
                Display($"{textBoxList[0].Text} with price {textBoxList[1].Text} was added !", cInformationMessage, MessageBoxIcon.Information);
            }
            else
            {
                Display("Drink name must be between 5 and 20 symbols long and price must be a number with value bigger than zero", cErrorMessage,MessageBoxIcon.Error);
            }
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
        private Button CreateDynamicControl(Button button, string name, int x, int y)
        {
            button = new Button();
            button.Location = new Point(x, y);
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
        private void Display(string text, string message, MessageBoxIcon messageBoxIcon)
        {

            MessageBox.Show(this, text, message, MessageBoxButtons.OK, messageBoxIcon);
        }
    }
}
