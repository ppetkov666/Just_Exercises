namespace DynamicallyCreatedTexBoxes
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
            this.stripMainMenu = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.DisplayPnl = new System.Windows.Forms.Panel();
            this.stripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripMainMenu
            // 
            this.stripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile});
            this.stripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.stripMainMenu.Name = "stripMainMenu";
            this.stripMainMenu.Size = new System.Drawing.Size(481, 24);
            this.stripMainMenu.TabIndex = 0;
            this.stripMainMenu.Text = "stripMainMenu";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.itemSaveAs});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(37, 20);
            this.itemFile.Text = "File";
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(111, 22);
            this.itemOpen.Text = "Open";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemSaveAs
            // 
            this.itemSaveAs.Enabled = false;
            this.itemSaveAs.Name = "itemSaveAs";
            this.itemSaveAs.Size = new System.Drawing.Size(111, 22);
            this.itemSaveAs.Text = "SaveAs";
            this.itemSaveAs.Click += new System.EventHandler(this.itemSaveAs_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "sample";
            this.saveFileDialog.Filter = "|*.txt";
            // 
            // DisplayPnl
            // 
            this.DisplayPnl.Location = new System.Drawing.Point(0, 27);
            this.DisplayPnl.Name = "DisplayPnl";
            this.DisplayPnl.Size = new System.Drawing.Size(477, 425);
            this.DisplayPnl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 457);
            this.Controls.Add(this.DisplayPnl);
            this.Controls.Add(this.stripMainMenu);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.stripMainMenu.ResumeLayout(false);
            this.stripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip stripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemSaveAs;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel DisplayPnl;
    }
}

