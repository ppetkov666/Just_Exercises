namespace WindowsFormsApp1
{
    partial class CheckForm
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
            this.bClickCounter = new System.Windows.Forms.Button();
            this.bShowClick = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bClickCounter
            // 
            this.bClickCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClickCounter.Location = new System.Drawing.Point(146, 32);
            this.bClickCounter.Name = "bClickCounter";
            this.bClickCounter.Size = new System.Drawing.Size(400, 88);
            this.bClickCounter.TabIndex = 0;
            this.bClickCounter.Text = "Click Counter";
            this.bClickCounter.UseVisualStyleBackColor = true;
            this.bClickCounter.Click += new System.EventHandler(this.SetMyNameButton_Click);
            // 
            // bShowClick
            // 
            this.bShowClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowClick.Location = new System.Drawing.Point(146, 172);
            this.bShowClick.Name = "bShowClick";
            this.bShowClick.Size = new System.Drawing.Size(400, 92);
            this.bShowClick.TabIndex = 1;
            this.bShowClick.Text = "Show Click\'s";
            this.bShowClick.UseVisualStyleBackColor = true;
            this.bShowClick.Click += new System.EventHandler(this.ShowMyNameButton_Click);
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(146, 302);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(400, 88);
            this.bReset.TabIndex = 2;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 429);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bShowClick);
            this.Controls.Add(this.bClickCounter);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.Load += new System.EventHandler(this.CheckForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClickCounter;
        private System.Windows.Forms.Button bShowClick;
        private System.Windows.Forms.Button bReset;
    }
}

