namespace DapperConnectionApp
{
    partial class DashBoard
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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.tblastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbFirstNameInsert = new System.Windows.Forms.TextBox();
            this.tbLastNameInsert = new System.Windows.Forms.TextBox();
            this.tbAgeInsert = new System.Windows.Forms.TextBox();
            this.tbCountryInsert = new System.Windows.Forms.TextBox();
            this.lblFirstNameInsert = new System.Windows.Forms.Label();
            this.lblLastNameInsert = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.bInsertData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 25;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(12, 183);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(576, 354);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // tblastName
            // 
            this.tblastName.Location = new System.Drawing.Point(180, 47);
            this.tblastName.Name = "tblastName";
            this.tblastName.Size = new System.Drawing.Size(408, 32);
            this.tblastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(118, 26);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(180, 104);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(408, 53);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbFirstNameInsert
            // 
            this.tbFirstNameInsert.Location = new System.Drawing.Point(883, 47);
            this.tbFirstNameInsert.Name = "tbFirstNameInsert";
            this.tbFirstNameInsert.Size = new System.Drawing.Size(408, 32);
            this.tbFirstNameInsert.TabIndex = 4;
            // 
            // tbLastNameInsert
            // 
            this.tbLastNameInsert.Location = new System.Drawing.Point(883, 104);
            this.tbLastNameInsert.Name = "tbLastNameInsert";
            this.tbLastNameInsert.Size = new System.Drawing.Size(408, 32);
            this.tbLastNameInsert.TabIndex = 5;
            // 
            // tbAgeInsert
            // 
            this.tbAgeInsert.Location = new System.Drawing.Point(883, 162);
            this.tbAgeInsert.Name = "tbAgeInsert";
            this.tbAgeInsert.Size = new System.Drawing.Size(408, 32);
            this.tbAgeInsert.TabIndex = 6;
            // 
            // tbCountryInsert
            // 
            this.tbCountryInsert.Location = new System.Drawing.Point(883, 224);
            this.tbCountryInsert.Name = "tbCountryInsert";
            this.tbCountryInsert.Size = new System.Drawing.Size(408, 32);
            this.tbCountryInsert.TabIndex = 7;
            // 
            // lblFirstNameInsert
            // 
            this.lblFirstNameInsert.AutoSize = true;
            this.lblFirstNameInsert.Location = new System.Drawing.Point(717, 53);
            this.lblFirstNameInsert.Name = "lblFirstNameInsert";
            this.lblFirstNameInsert.Size = new System.Drawing.Size(109, 26);
            this.lblFirstNameInsert.TabIndex = 8;
            this.lblFirstNameInsert.Text = "Firstname";
            // 
            // lblLastNameInsert
            // 
            this.lblLastNameInsert.AutoSize = true;
            this.lblLastNameInsert.Location = new System.Drawing.Point(717, 110);
            this.lblLastNameInsert.Name = "lblLastNameInsert";
            this.lblLastNameInsert.Size = new System.Drawing.Size(118, 26);
            this.lblLastNameInsert.TabIndex = 9;
            this.lblLastNameInsert.Text = "Last Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(717, 168);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(51, 26);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(717, 230);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(88, 26);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Country";
            // 
            // bInsertData
            // 
            this.bInsertData.Location = new System.Drawing.Point(883, 294);
            this.bInsertData.Name = "bInsertData";
            this.bInsertData.Size = new System.Drawing.Size(408, 53);
            this.bInsertData.TabIndex = 12;
            this.bInsertData.Text = "Insert";
            this.bInsertData.UseVisualStyleBackColor = true;
            this.bInsertData.Click += new System.EventHandler(this.bInsertData_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 619);
            this.Controls.Add(this.bInsertData);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastNameInsert);
            this.Controls.Add(this.lblFirstNameInsert);
            this.Controls.Add(this.tbCountryInsert);
            this.Controls.Add(this.tbAgeInsert);
            this.Controls.Add(this.tbLastNameInsert);
            this.Controls.Add(this.tbFirstNameInsert);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tblastName);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DashBoard";
            this.Text = "SQL Data Access Demo";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox tblastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbFirstNameInsert;
        private System.Windows.Forms.TextBox tbLastNameInsert;
        private System.Windows.Forms.TextBox tbAgeInsert;
        private System.Windows.Forms.TextBox tbCountryInsert;
        private System.Windows.Forms.Label lblFirstNameInsert;
        private System.Windows.Forms.Label lblLastNameInsert;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button bInsertData;
    }
}

