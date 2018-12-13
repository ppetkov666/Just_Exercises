namespace CoffeeApp
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    partial class f_main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_add_user = new System.Windows.Forms.Button();
            this.DisplayPnl = new System.Windows.Forms.Panel();
            this.b_submit = new System.Windows.Forms.Button();
            this.cb_quantity = new System.Windows.Forms.ComboBox();
            this.cb_drinks = new System.Windows.Forms.ComboBox();
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_choose_drink = new System.Windows.Forms.Label();
            this.llb_choose_user = new System.Windows.Forms.Label();
            this.b_return_to_main_page = new System.Windows.Forms.Button();
            this.b_add_drink = new System.Windows.Forms.Button();
            this.b_report = new System.Windows.Forms.Button();
            this.b_custom_report = new System.Windows.Forms.Button();
            this.DisplayPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_add_user
            // 
            this.b_add_user.Location = new System.Drawing.Point(766, 40);
            this.b_add_user.Name = "b_add_user";
            this.b_add_user.Size = new System.Drawing.Size(150, 23);
            this.b_add_user.TabIndex = 0;
            this.b_add_user.Text = "Add User";
            this.b_add_user.UseVisualStyleBackColor = true;
            this.b_add_user.Click += new System.EventHandler(this.b_add_user_Click);
            // 
            // DisplayPnl
            // 
            this.DisplayPnl.Controls.Add(this.b_submit);
            this.DisplayPnl.Controls.Add(this.cb_quantity);
            this.DisplayPnl.Controls.Add(this.cb_drinks);
            this.DisplayPnl.Controls.Add(this.cb_users);
            this.DisplayPnl.Controls.Add(this.lbl_quantity);
            this.DisplayPnl.Controls.Add(this.lbl_choose_drink);
            this.DisplayPnl.Controls.Add(this.llb_choose_user);
            this.DisplayPnl.Location = new System.Drawing.Point(0, 0);
            this.DisplayPnl.Name = "DisplayPnl";
            this.DisplayPnl.Size = new System.Drawing.Size(760, 265);
            this.DisplayPnl.TabIndex = 1;
            // 
            // b_submit
            // 
            this.b_submit.Location = new System.Drawing.Point(240, 143);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(150, 23);
            this.b_submit.TabIndex = 6;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // cb_quantity
            // 
            this.cb_quantity.FormattingEnabled = true;
            this.cb_quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cb_quantity.Location = new System.Drawing.Point(120, 100);
            this.cb_quantity.Name = "cb_quantity";
            this.cb_quantity.Size = new System.Drawing.Size(270, 21);
            this.cb_quantity.TabIndex = 5;
            // 
            // cb_drinks
            // 
            this.cb_drinks.FormattingEnabled = true;
            this.cb_drinks.Location = new System.Drawing.Point(120, 70);
            this.cb_drinks.Name = "cb_drinks";
            this.cb_drinks.Size = new System.Drawing.Size(270, 21);
            this.cb_drinks.TabIndex = 4;
            // 
            // cb_users
            // 
            this.cb_users.FormattingEnabled = true;
            this.cb_users.Location = new System.Drawing.Point(120, 40);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(270, 21);
            this.cb_users.TabIndex = 3;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(12, 100);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_choose_drink
            // 
            this.lbl_choose_drink.AutoSize = true;
            this.lbl_choose_drink.Location = new System.Drawing.Point(12, 70);
            this.lbl_choose_drink.Name = "lbl_choose_drink";
            this.lbl_choose_drink.Size = new System.Drawing.Size(59, 13);
            this.lbl_choose_drink.TabIndex = 1;
            this.lbl_choose_drink.Text = "Drink Type";
            // 
            // llb_choose_user
            // 
            this.llb_choose_user.AutoSize = true;
            this.llb_choose_user.Location = new System.Drawing.Point(12, 40);
            this.llb_choose_user.Name = "llb_choose_user";
            this.llb_choose_user.Size = new System.Drawing.Size(99, 13);
            this.llb_choose_user.TabIndex = 0;
            this.llb_choose_user.Text = "Choose User Name";
            // 
            // b_return_to_main_page
            // 
            this.b_return_to_main_page.Location = new System.Drawing.Point(766, 100);
            this.b_return_to_main_page.Name = "b_return_to_main_page";
            this.b_return_to_main_page.Size = new System.Drawing.Size(150, 23);
            this.b_return_to_main_page.TabIndex = 2;
            this.b_return_to_main_page.Text = "Return to Main Menu";
            this.b_return_to_main_page.UseVisualStyleBackColor = true;
            this.b_return_to_main_page.Click += new System.EventHandler(this.b_return_to_main_page_Click);
            // 
            // b_add_drink
            // 
            this.b_add_drink.Location = new System.Drawing.Point(766, 70);
            this.b_add_drink.Name = "b_add_drink";
            this.b_add_drink.Size = new System.Drawing.Size(150, 23);
            this.b_add_drink.TabIndex = 3;
            this.b_add_drink.Text = "Add Drink";
            this.b_add_drink.UseVisualStyleBackColor = true;
            this.b_add_drink.Click += new System.EventHandler(this.b_add_drink_Click);
            // 
            // b_report
            // 
            this.b_report.Location = new System.Drawing.Point(766, 158);
            this.b_report.Name = "b_report";
            this.b_report.Size = new System.Drawing.Size(150, 23);
            this.b_report.TabIndex = 4;
            this.b_report.Text = "Full Report";
            this.b_report.UseVisualStyleBackColor = true;
            this.b_report.Click += new System.EventHandler(this.b_report_Click);
            // 
            // b_custom_report
            // 
            this.b_custom_report.Location = new System.Drawing.Point(766, 129);
            this.b_custom_report.Name = "b_custom_report";
            this.b_custom_report.Size = new System.Drawing.Size(150, 23);
            this.b_custom_report.TabIndex = 5;
            this.b_custom_report.Text = "Custom Report";
            this.b_custom_report.UseVisualStyleBackColor = true;
            this.b_custom_report.Click += new System.EventHandler(this.b_custom_report_Click);
            // 
            // f_main_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(974, 277);
            this.Controls.Add(this.b_custom_report);
            this.Controls.Add(this.b_report);
            this.Controls.Add(this.b_add_drink);
            this.Controls.Add(this.b_return_to_main_page);
            this.Controls.Add(this.DisplayPnl);
            this.Controls.Add(this.b_add_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f_main_form";
            this.Text = "coffee_app_form";
            this.Load += new System.EventHandler(this.Main_form_load);
            this.DisplayPnl.ResumeLayout(false);
            this.DisplayPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button b_add_user;
        private Panel DisplayPnl;
        private Button b_return_to_main_page;
        private Button b_add_drink;
        private ComboBox cb_quantity;
        private ComboBox cb_drinks;
        private ComboBox cb_users;
        private Label lbl_quantity;
        private Label lbl_choose_drink;
        private Label llb_choose_user;
        private Button b_submit;
        private Button b_report;
        private Button b_custom_report;
    }
}

