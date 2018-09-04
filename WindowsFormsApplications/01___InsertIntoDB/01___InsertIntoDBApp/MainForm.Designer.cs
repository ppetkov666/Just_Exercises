namespace _02___InsertIntoDB
{
    partial class MainForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.bInsert = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tbTownID = new System.Windows.Forms.TextBox();
            this.lblTownId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(169, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(173, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(169, 71);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(173, 20);
            this.tbAge.TabIndex = 1;
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.Location = new System.Drawing.Point(169, 116);
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.Size = new System.Drawing.Size(173, 20);
            this.tbIDNumber.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(83, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(92, 78);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(60, 123);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(58, 13);
            this.lblIDNumber.TabIndex = 5;
            this.lblIDNumber.Text = "ID Number";
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(169, 240);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(166, 38);
            this.bInsert.TabIndex = 4;
            this.bInsert.Text = "Inser Into Data Base";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(169, 311);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(166, 36);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tbTownID
            // 
            this.tbTownID.Location = new System.Drawing.Point(169, 161);
            this.tbTownID.Name = "tbTownID";
            this.tbTownID.Size = new System.Drawing.Size(173, 20);
            this.tbTownID.TabIndex = 3;
            // 
            // lblTownId
            // 
            this.lblTownId.AutoSize = true;
            this.lblTownId.Location = new System.Drawing.Point(60, 168);
            this.lblTownId.Name = "lblTownId";
            this.lblTownId.Size = new System.Drawing.Size(48, 13);
            this.lblTownId.TabIndex = 9;
            this.lblTownId.Text = "Town ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 404);
            this.Controls.Add(this.lblTownId);
            this.Controls.Add(this.tbTownID);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbIDNumber);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox tbTownID;
        private System.Windows.Forms.Label lblTownId;
    }
}

