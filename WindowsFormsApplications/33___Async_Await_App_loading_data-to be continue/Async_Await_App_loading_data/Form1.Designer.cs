using System;
using System.Windows.Forms;

namespace Async_Await_App_loading_data
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
            this.btn_async_execute = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.prb_my_custom_loading = new ColorProgressBar.ColorProgressBar();
            this.btn_parallel_async = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            //this.progress = new Progress<ProgressReportModel>();
            this.SuspendLayout();
            // 
            // btn_execute_sync
            // 
            this.btn_execute_sync.Location = new System.Drawing.Point(119, 22);
            this.btn_execute_sync.Name = "btn_execute_sync";
            this.btn_execute_sync.Size = new System.Drawing.Size(448, 40);
            this.btn_execute_sync.TabIndex = 0;
            this.btn_execute_sync.Text = "Execute Sync";
            this.btn_execute_sync.UseVisualStyleBackColor = true;
            this.btn_execute_sync.Click += new System.EventHandler(this.Btn_execute_sync_Click);
            // 
            // btn_async_execute
            // 
            this.btn_async_execute.Location = new System.Drawing.Point(119, 68);
            this.btn_async_execute.Name = "btn_async_execute";
            this.btn_async_execute.Size = new System.Drawing.Size(448, 40);
            this.btn_async_execute.TabIndex = 1;
            this.btn_async_execute.Text = "Execute Async";
            this.btn_async_execute.UseVisualStyleBackColor = true;
            this.btn_async_execute.Click += new System.EventHandler(this.Btn_async_execute_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(119, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 238);
            this.listBox1.TabIndex = 2;
            // 
            // prb_my_custom_loading
            // 
            this.prb_my_custom_loading.BarColor = System.Drawing.Color.Aqua;
            this.prb_my_custom_loading.BorderColor = System.Drawing.Color.White;
            this.prb_my_custom_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.prb_my_custom_loading.Location = new System.Drawing.Point(119, 206);
            this.prb_my_custom_loading.Maximum = 100;
            this.prb_my_custom_loading.Minimum = 0;
            this.prb_my_custom_loading.Name = "prb_my_custom_loading";
            this.prb_my_custom_loading.Size = new System.Drawing.Size(448, 40);
            this.prb_my_custom_loading.Step = 10;
            this.prb_my_custom_loading.TabIndex = 4;
            this.prb_my_custom_loading.Value = 0;
            // 
            // btn_parallel_async
            // 
            this.btn_parallel_async.Location = new System.Drawing.Point(119, 114);
            this.btn_parallel_async.Name = "btn_parallel_async";
            this.btn_parallel_async.Size = new System.Drawing.Size(448, 40);
            this.btn_parallel_async.TabIndex = 5;
            this.btn_parallel_async.Text = "Execute Parallel Async";
            this.btn_parallel_async.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_parallel_async.UseVisualStyleBackColor = true;
            this.btn_parallel_async.Click += new System.EventHandler(this.btn_parallel_async_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(119, 160);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(448, 40);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // progress
            //
            //this.progress.ProgressChanged += Progress_ProgressChanged;
            
            // 
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 545);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_parallel_async);
            this.Controls.Add(this.prb_my_custom_loading);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_async_execute);
            this.Controls.Add(this.btn_execute_sync);
            
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_execute_sync;
        private System.Windows.Forms.Button btn_async_execute;
        private System.Windows.Forms.ListBox listBox1;
        private ColorProgressBar.ColorProgressBar prb_my_custom_loading;
        private System.Windows.Forms.Button btn_parallel_async;
        private System.Windows.Forms.Button btn_cancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private Progress<ProgressReportModel> progress;
    }
}

