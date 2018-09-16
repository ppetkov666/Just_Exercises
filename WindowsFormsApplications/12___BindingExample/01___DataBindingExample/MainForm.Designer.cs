using System.Windows.Forms;

namespace _13___AnotherDataBindingExample
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
            this.TextBoxCustomerName = new System.Windows.Forms.TextBox();
            this.ButtonShowCustomer = new System.Windows.Forms.Button();
            this.ButtonChangeCustomer = new System.Windows.Forms.Button();
            this.ButtonRebind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.Location = new System.Drawing.Point(66, 64);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(228, 26);
            this.TextBoxCustomerName.TabIndex = 0;
            // 
            // ButtonShowCustomer
            // 
            this.ButtonShowCustomer.Location = new System.Drawing.Point(66, 180);
            this.ButtonShowCustomer.Name = "ButtonShowCustomer";
            this.ButtonShowCustomer.Size = new System.Drawing.Size(228, 50);
            this.ButtonShowCustomer.TabIndex = 1;
            this.ButtonShowCustomer.Text = "Show Customer Name";
            this.ButtonShowCustomer.UseVisualStyleBackColor = true;
            this.ButtonShowCustomer.Click += new System.EventHandler(this.ButtonShowCustomer_Click);
            // 
            // ButtonChangeCustomer
            // 
            this.ButtonChangeCustomer.Location = new System.Drawing.Point(66, 258);
            this.ButtonChangeCustomer.Name = "ButtonChangeCustomer";
            this.ButtonChangeCustomer.Size = new System.Drawing.Size(228, 50);
            this.ButtonChangeCustomer.TabIndex = 2;
            this.ButtonChangeCustomer.Text = "Change Customer Name";
            this.ButtonChangeCustomer.UseVisualStyleBackColor = true;
            this.ButtonChangeCustomer.Click += new System.EventHandler(this.ButtonChangeCustomer_Click);
            // 
            // ButtonRebind
            // 
            this.ButtonRebind.Location = new System.Drawing.Point(66, 327);
            this.ButtonRebind.Name = "ButtonRebind";
            this.ButtonRebind.Size = new System.Drawing.Size(228, 50);
            this.ButtonRebind.TabIndex = 3;
            this.ButtonRebind.Text = "Rebind";
            this.ButtonRebind.UseVisualStyleBackColor = true;
            this.ButtonRebind.Click += new System.EventHandler(this.ButtonRebind_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 461);
            this.Controls.Add(this.ButtonRebind);
            this.Controls.Add(this.ButtonChangeCustomer);
            this.Controls.Add(this.ButtonShowCustomer);
            this.Controls.Add(this.TextBoxCustomerName);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.TextBox TextBoxCustomerName;
        private System.Windows.Forms.Button ButtonShowCustomer;
        private System.Windows.Forms.Button ButtonChangeCustomer;
        private System.Windows.Forms.Button ButtonRebind;
    }
}

