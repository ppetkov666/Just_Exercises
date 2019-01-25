namespace Thread_and_Callback_simple_example
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_enter_number = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.prb_loading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            resources.ApplyResources(this.btn_start, "btn_start");
            this.btn_start.Name = "btn_start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // lbl_count
            // 
            resources.ApplyResources(this.lbl_count, "lbl_count");
            this.lbl_count.Name = "lbl_count";
            // 
            // lbl_enter_number
            // 
            resources.ApplyResources(this.lbl_enter_number, "lbl_enter_number");
            this.lbl_enter_number.Name = "lbl_enter_number";
            // 
            // tb_number
            // 
            resources.ApplyResources(this.tb_number, "tb_number");
            this.tb_number.Name = "tb_number";
            // 
            // prb_loading
            // 
            resources.ApplyResources(this.prb_loading, "prb_loading");
            this.prb_loading.Name = "prb_loading";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prb_loading);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lbl_enter_number);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_enter_number;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.ProgressBar prb_loading;
    }
}

