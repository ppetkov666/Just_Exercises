namespace _08___
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
            this.bButtonCallDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bButtonCallDialog
            // 
            this.bButtonCallDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bButtonCallDialog.Location = new System.Drawing.Point(135, 96);
            this.bButtonCallDialog.Name = "bButtonCallDialog";
            this.bButtonCallDialog.Size = new System.Drawing.Size(286, 89);
            this.bButtonCallDialog.TabIndex = 0;
            this.bButtonCallDialog.Text = "ButtonCallDialog";
            this.bButtonCallDialog.UseVisualStyleBackColor = true;
            this.bButtonCallDialog.Click += new System.EventHandler(this.bButtonCallDialog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 298);
            this.Controls.Add(this.bButtonCallDialog);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bButtonCallDialog;
    }
}