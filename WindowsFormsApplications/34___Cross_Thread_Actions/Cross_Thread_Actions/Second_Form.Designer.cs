namespace Cross_Thread_Actions
{
    partial class Second_Form
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
            this.tb_textbox_input_second = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_textbox_input_second
            // 
            this.tb_textbox_input_second.Location = new System.Drawing.Point(12, 12);
            this.tb_textbox_input_second.Multiline = true;
            this.tb_textbox_input_second.Name = "tb_textbox_input_second";
            this.tb_textbox_input_second.Size = new System.Drawing.Size(417, 145);
            this.tb_textbox_input_second.TabIndex = 1;
            // 
            // Second_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 169);
            this.Controls.Add(this.tb_textbox_input_second);
            this.Name = "Second_Form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_textbox_input_second;
    }
}