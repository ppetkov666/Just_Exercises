namespace _04___Reading_from_file_with_Background_worker
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
            this.prb_FileCounter = new System.Windows.Forms.ProgressBar();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_percentage = new System.Windows.Forms.Label();
            this.bgw_worker = new System.ComponentModel.BackgroundWorker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prb_FileCounter
            // 
            this.prb_FileCounter.Location = new System.Drawing.Point(85, 151);
            this.prb_FileCounter.Margin = new System.Windows.Forms.Padding(2);
            this.prb_FileCounter.Name = "prb_FileCounter";
            this.prb_FileCounter.Size = new System.Drawing.Size(487, 34);
            this.prb_FileCounter.TabIndex = 10;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(250, 112);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(0, 17);
            this.lbl_count.TabIndex = 9;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(85, 42);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(133, 37);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Press Start To Count ";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // lbl_percentage
            // 
            this.lbl_percentage.AutoSize = true;
            this.lbl_percentage.Location = new System.Drawing.Point(599, 151);
            this.lbl_percentage.Name = "lbl_percentage";
            this.lbl_percentage.Size = new System.Drawing.Size(15, 13);
            this.lbl_percentage.TabIndex = 11;
            this.lbl_percentage.Text = "%";
            // 
            // bgw_worker
            // 
            this.bgw_worker.WorkerReportsProgress = true;
            this.bgw_worker.WorkerSupportsCancellation = true;
            this.bgw_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_worker_DoWork);
            this.bgw_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bgw_worker_ProgressChanged);
            this.bgw_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw_worker_RunWorkerCompleted);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(439, 42);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(133, 37);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 282);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_percentage);
            this.Controls.Add(this.prb_FileCounter);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prb_FileCounter;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_percentage;
        private System.ComponentModel.BackgroundWorker bgw_worker;
        private System.Windows.Forms.Button btn_cancel;
    }
}

