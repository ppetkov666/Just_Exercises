namespace _02___Second_Example
{
    partial class Form1
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
            this.prb_loading = new System.Windows.Forms.ProgressBar();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.lbl_enter_number = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prb_loading
            // 
            this.prb_loading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prb_loading.Location = new System.Drawing.Point(93, 157);
            this.prb_loading.Name = "prb_loading";
            this.prb_loading.Size = new System.Drawing.Size(573, 23);
            this.prb_loading.TabIndex = 12;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(258, 66);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(181, 20);
            this.tb_number.TabIndex = 11;
            // 
            // lbl_enter_number
            // 
            this.lbl_enter_number.AutoSize = true;
            this.lbl_enter_number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_enter_number.Location = new System.Drawing.Point(90, 66);
            this.lbl_enter_number.Name = "lbl_enter_number";
            this.lbl_enter_number.Size = new System.Drawing.Size(122, 13);
            this.lbl_enter_number.TabIndex = 10;
            this.lbl_enter_number.Text = "Please Enter a Number :";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_count.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_count.Location = new System.Drawing.Point(255, 111);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(248, 17);
            this.lbl_count.TabIndex = 9;
            this.lbl_count.Text = "The sum of digits will be printed Here !";
            // 
            // btn_start
            // 
            this.btn_start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_start.Location = new System.Drawing.Point(490, 66);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(176, 20);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Press Start To Count ";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 238);
            this.Controls.Add(this.prb_loading);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lbl_enter_number);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prb_loading;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label lbl_enter_number;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_start;
    }
}

