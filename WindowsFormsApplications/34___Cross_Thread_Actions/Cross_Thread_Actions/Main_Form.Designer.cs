namespace Cross_Thread_Actions
{
    partial class frm_main
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
            this.tb_textbox_input = new System.Windows.Forms.TextBox();
            this.btn_send_text = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_open_new_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_textbox_input
            // 
            this.tb_textbox_input.Location = new System.Drawing.Point(12, 12);
            this.tb_textbox_input.Multiline = true;
            this.tb_textbox_input.Name = "tb_textbox_input";
            this.tb_textbox_input.Size = new System.Drawing.Size(425, 138);
            this.tb_textbox_input.TabIndex = 0;
            // 
            // btn_send_text
            // 
            this.btn_send_text.Location = new System.Drawing.Point(12, 218);
            this.btn_send_text.Name = "btn_send_text";
            this.btn_send_text.Size = new System.Drawing.Size(137, 33);
            this.btn_send_text.TabIndex = 1;
            this.btn_send_text.Text = "Send To Second Form";
            this.btn_send_text.UseVisualStyleBackColor = true;
            this.btn_send_text.Click += new System.EventHandler(this.Btn_send_text_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(300, 218);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(137, 33);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(155, 218);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(137, 33);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Open/Clear Text";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // btn_open_new_form
            // 
            this.btn_open_new_form.Location = new System.Drawing.Point(12, 179);
            this.btn_open_new_form.Name = "btn_open_new_form";
            this.btn_open_new_form.Size = new System.Drawing.Size(425, 33);
            this.btn_open_new_form.TabIndex = 4;
            this.btn_open_new_form.Text = "Open New Form";
            this.btn_open_new_form.UseVisualStyleBackColor = true;
            this.btn_open_new_form.Click += new System.EventHandler(this.btn_open_new_form_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 319);
            this.Controls.Add(this.btn_open_new_form);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_send_text);
            this.Controls.Add(this.tb_textbox_input);
            this.Name = "frm_main";
            this.Text = "Main form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_textbox_input;
        private System.Windows.Forms.Button btn_send_text;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_open_new_form;
    }
}

