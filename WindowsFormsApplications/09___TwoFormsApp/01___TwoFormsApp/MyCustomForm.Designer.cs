namespace _08___
{
    using System.Windows.Forms;
    public partial class cMyCustomForm
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bSetDefaultValue = new System.Windows.Forms.Button();
            this.tbTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bDelete = new System.Windows.Forms.Button();
            this.lblEnterYourName = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSetDefaultValue
            // 
            this.bSetDefaultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSetDefaultValue.Location = new System.Drawing.Point(573, 193);
            this.bSetDefaultValue.Name = "bSetDefaultValue";
            this.bSetDefaultValue.Size = new System.Drawing.Size(427, 88);
            this.bSetDefaultValue.TabIndex = 3;
            this.bSetDefaultValue.Text = "Set Default Value";
            this.bSetDefaultValue.UseVisualStyleBackColor = true;
            this.bSetDefaultValue.Click += new System.EventHandler(this.bSetDefaultValue_Click);
            // 
            // tbTextBox
            // 
            this.tbTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextBox.Location = new System.Drawing.Point(311, 116);
            this.tbTextBox.Name = "tbTextBox";
            this.tbTextBox.Size = new System.Drawing.Size(193, 35);
            this.tbTextBox.TabIndex = 1;
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(573, 61);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(427, 90);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lblEnterYourName
            // 
            this.lblEnterYourName.AutoSize = true;
            this.lblEnterYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterYourName.Location = new System.Drawing.Point(49, 116);
            this.lblEnterYourName.Name = "lblEnterYourName";
            this.lblEnterYourName.Size = new System.Drawing.Size(198, 29);
            this.lblEnterYourName.TabIndex = 3;
            this.lblEnterYourName.Text = "Enter Your Name";
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOk.Location = new System.Drawing.Point(115, 244);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(132, 37);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(363, 244);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(132, 37);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // cMyCustomForm
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(1074, 346);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lblEnterYourName);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.tbTextBox);
            this.Controls.Add(this.bSetDefaultValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "cMyCustomForm";
            this.Text = "MyCustomForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private TextBox tbTextBox;
        private Timer timer1;
        private Button bDelete;
        private Label lblEnterYourName;
        private Button bOk;
        private Button bCancel;
        private Button bSetDefaultValue;
    }
}

