
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
        private bool isEmpthy = false;
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
            cb_users.SelectedItem = null;
            cb_drinks.SelectedItem = null;
        }
        private void b_add_user_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayTextBoxesAndLabels("First Name", "Last Name", mAddUserNumOfFields);
            b_submit_user_name = DynamicControls.CreateButton(b_submit_user_name, "b_submit_user_name", 240, 100);
            b_submit_user_name.Click += B_submit_user_name_Click;
            DisplayPnl.Controls.Add(b_submit_user_name);
        }
        private void b_add_drink_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            DisplayTextBoxesAndLabels("Drink Name", "Price", mAddDrinkNumOfFields);
            b_submit_drink = DynamicControls.CreateButton(b_submit_drink, "b_submit_drink", 240, 100);
            b_submit_drink.Click += B_submit_drink_Click;
            DisplayPnl.Controls.Add(b_submit_drink);
        }
        private void b_return_to_main_page_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            GetBindedInfoFromDB();
            
            DisplayPnl.Controls.Add(lbl_quantity);
            DisplayPnl.Controls.Add(lbl_choose_drink);
            DisplayPnl.Controls.Add(lbl_choose_user);
            DisplayPnl.Controls.Add(cb_users);
            DisplayPnl.Controls.Add(cb_drinks);
            DisplayPnl.Controls.Add(cb_quantity);
            DisplayPnl.Controls.Add(b_main_submit_user_drink_quantity);
            DisplayPnl.Controls.Add(prb_loading);
            cb_users.SelectedItem = null;
            cb_drinks.SelectedItem = null;
            cb_quantity.SelectedItem = null;
        }
        private void b_custom_report_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();

            // create dynamically button
            b_submit_custom_info = DynamicControls.CreateButton(b_submit_custom_info, "b_submit_custom_info", 562, 40);
            b_submit_custom_info.Click += B_submit_custom_info_Click;
            // add it to Panel 
            DisplayPnl.Controls.Add(lbl_choose_user);
            DisplayPnl.Controls.Add(cb_users);
            list_box_result = DynamicControls.CreateListBox(list_box_result);
            DisplayPnl.Controls.Add(list_box_result);
            DisplayPnl.Controls.Add(b_submit_custom_info);
        }
        private void b_report_Click(object sender, EventArgs e)
        {
            DisplayPnl.Controls.Clear();
            dgw_table = DynamicControls.CreateDataGridView(dgw_table);
            DisplayPnl.Controls.Add(dgw_table);
            DataAcccess db = new DataAcccess();
            dgw_table.DataSource = db.GetDataSet();
        }
        private void b_main_submit_user_drink_quantity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cb_users.Text)|| string.IsNullOrWhiteSpace(cb_drinks.Text)|| string.IsNullOrWhiteSpace(cb_quantity.Text))
            {
                Display("All fields must be selected", cErrorMessage, MessageBoxIcon.Error);
            }
            else
            {
                SetProgressBar(int.Parse(cb_quantity.Text));
                for (int i = 0; i < int.Parse(cb_quantity.Text); i++)
                {
                    prb_loading.Value += 1;
                }
                DataAcccess db = new DataAcccess();
                db.InsertIntoDB(cb_users.Text, cb_drinks.Text, int.Parse(cb_quantity.Text));
                Display($"{cb_drinks.Text} with quantity {cb_quantity.Text} has been added to {cb_users.Text} account", cInformationMessage, MessageBoxIcon.Information);
            }
        }
        private void B_submit_user_name_Click(object sender, EventArgs e)
        {
            if (isEmpthy = CheckForEmpthyInput() == true)
            {
                return;
            }
            if (!Regex.IsMatch(textBoxList[0].Text, @"^[a-zA-Z]+$") ||
                !Regex.IsMatch(textBoxList[1].Text, @"^[a-zA-Z]+$"))
            {
                Display("First or Last name must be consisted of letters only", cErrorMessage, MessageBoxIcon.Error);
            }
            else if ((textBoxList[0].Text.Length < 2 || textBoxList[0].Text.Length > 20) &&
                     (textBoxList[1].Text.Length < 2 || textBoxList[1].Text.Length > 20))
            {
                Display("First and Last name must be between 2 and 20 symbols long", cErrorMessage, MessageBoxIcon.Error);
            }
            else
            {
                DataAcccess db = new DataAcccess();
                db.InsertUserIntoDB(textBoxList[0].Text, textBoxList[1].Text);
                Display($"{textBoxList[0].Text} {textBoxList[1].Text} was added !", cInformationMessage, MessageBoxIcon.Information);
            }
        }

        private void B_submit_drink_Click(object sender, EventArgs e)
        {
            if (isEmpthy = CheckForEmpthyInput() == true)
            {
                return;
            }
            double parsedInput;
            if (double.TryParse(textBoxList[1].Text, out parsedInput) &&
               (parsedInput > 0) &&
               (textBoxList[0].Text.Length >= 5 && textBoxList[0].Text.Length <= 20))
            {
                DataAcccess db = new DataAcccess();
                db.InsertDrinks(textBoxList[0].Text, parsedInput);
                Display($"{textBoxList[0].Text} with price {textBoxList[1].Text} was added !", cInformationMessage, MessageBoxIcon.Information);
            }
            else
            {
                Display("Drink name must be between 5 and 20 symbols long and price must be a number with value bigger than zero", cErrorMessage, MessageBoxIcon.Error);
            }
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

            // create dynamically label
            lbl_custom_report = DynamicControls.CreateLabelPrint(lbl_custom_report, user, cb_users);
            DisplayPnl.Controls.Add(lbl_custom_report);
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
        public void DisplayTextBoxesAndLabels(string firstLabelText, string secondLabelText, int numOfFields)
        {
            textBoxList = new List<TextBox>();
            labelList = new List<Label>();

            for (int i = 1; i <= numOfFields; i++)
            {
                if (i == 1)
                {
                    labelList.Add(DynamicControls.CreateLabel(firstLabelText, i));
                    textBoxList.Add(DynamicControls.CreateTextBox(i));
                }
                else if (i == 2)
                {
                    labelList.Add(DynamicControls.CreateLabel(secondLabelText, i));
                    textBoxList.Add(DynamicControls.CreateTextBox(i));
                }
            }
            for (int i = 0; i < textBoxList.Count; i++)
            {
                DisplayPnl.Controls.Add(textBoxList[i]);
                DisplayPnl.Controls.Add(labelList[i]);
            }
        }
        private void Display(string text, string message, MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(this, text, message, MessageBoxButtons.OK, messageBoxIcon);
        }
        private void SetProgressBar(int quantity)
        {
            prb_loading.Maximum = quantity;
            prb_loading.Value = 0;
            prb_loading.Visible = true;
        }
        private bool CheckForEmpthyInput()
        {

            if (string.IsNullOrWhiteSpace(textBoxList[0].Text) || string.IsNullOrWhiteSpace(textBoxList[1].Text))
            {
                Display("Both fields are mandatory", cErrorMessage, MessageBoxIcon.Error);
                isEmpthy = true;
            }
            return isEmpthy;
        }
    }
}
