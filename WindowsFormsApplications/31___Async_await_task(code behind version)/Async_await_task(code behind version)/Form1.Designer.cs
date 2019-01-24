namespace Async_await_task_code_behind_version_
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
            this.btn_execute_sync = new System.Windows.Forms.Button();
            this.btn_execute_async = new System.Windows.Forms.Button();
            this.btn_execute_parallel = new System.Windows.Forms.Button();
            this.prb_loading = new System.Windows.Forms.ProgressBar();
            this.lb_list_of_content = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_execute_sync
            // 
            this.btn_execute_sync.Location = new System.Drawing.Point(152, 22);
            this.btn_execute_sync.Name = "btn_execute_sync";
            this.btn_execute_sync.Size = new System.Drawing.Size(558, 34);
            this.btn_execute_sync.TabIndex = 0;
            this.btn_execute_sync.Text = "Execute Sync";
            this.btn_execute_sync.UseVisualStyleBackColor = true;
            this.btn_execute_sync.Click += new System.EventHandler(this.Btn_execute_sync_Click);
            // 
            // btn_execute_async
            // 
            this.btn_execute_async.Location = new System.Drawing.Point(152, 62);
            this.btn_execute_async.Name = "btn_execute_async";
            this.btn_execute_async.Size = new System.Drawing.Size(558, 37);
            this.btn_execute_async.TabIndex = 1;
            this.btn_execute_async.Text = "Execute Async";
            this.btn_execute_async.UseVisualStyleBackColor = true;
            this.btn_execute_async.Click += new System.EventHandler(this.Btn_execute_async_Click);
            // 
            // btn_execute_parallel
            // 
            this.btn_execute_parallel.Location = new System.Drawing.Point(152, 105);
            this.btn_execute_parallel.Name = "btn_execute_parallel";
            this.btn_execute_parallel.Size = new System.Drawing.Size(558, 37);
            this.btn_execute_parallel.TabIndex = 2;
            this.btn_execute_parallel.Text = "Execute Parallel Async";
            this.btn_execute_parallel.UseVisualStyleBackColor = true;
            this.btn_execute_parallel.Click += new System.EventHandler(this.btn_execute_parallel_Click);
            // 
            // prb_loading
            // 
            this.prb_loading.Location = new System.Drawing.Point(152, 149);
            this.prb_loading.Name = "prb_loading";
            this.prb_loading.Size = new System.Drawing.Size(558, 33);
            this.prb_loading.TabIndex = 3;
            // 
            // lb_list_of_content
            // 
            this.lb_list_of_content.FormattingEnabled = true;
            this.lb_list_of_content.Location = new System.Drawing.Point(152, 203);
            this.lb_list_of_content.Name = "lb_list_of_content";
            this.lb_list_of_content.Size = new System.Drawing.Size(558, 95);
            this.lb_list_of_content.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 364);
            this.Controls.Add(this.lb_list_of_content);
            this.Controls.Add(this.prb_loading);
            this.Controls.Add(this.btn_execute_parallel);
            this.Controls.Add(this.btn_execute_async);
            this.Controls.Add(this.btn_execute_sync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_execute_sync;
        private System.Windows.Forms.Button btn_execute_async;
        private System.Windows.Forms.Button btn_execute_parallel;
        private System.Windows.Forms.ProgressBar prb_loading;
        private System.Windows.Forms.ListBox lb_list_of_content;
    }
}

