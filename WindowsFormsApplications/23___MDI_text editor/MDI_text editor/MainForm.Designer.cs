namespace _11___MDI_TextEditor
{
    partial class TextEditorDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorDemo));
            this.MenuMainForm = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarMainForm = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ImageListToolBar = new System.Windows.Forms.ImageList(this.components);
            this.StatusBarMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuMainForm.SuspendLayout();
            this.ToolBarMainForm.SuspendLayout();
            this.StatusBarMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMainForm
            // 
            this.MenuMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenu,
            this.windowToolStripMenuItem});
            this.MenuMainForm.Location = new System.Drawing.Point(0, 0);
            this.MenuMainForm.Name = "MenuMainForm";
            this.MenuMainForm.Size = new System.Drawing.Size(790, 24);
            this.MenuMainForm.TabIndex = 0;
            this.MenuMainForm.Text = "MenuMainForm";
            // 
            // FileToolStripMenu
            // 
            this.FileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemFileExit});
            this.FileToolStripMenu.Name = "FileToolStripMenu";
            this.FileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenu.Text = "File";
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTRLNToolStripMenuItem});
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            this.MenuItemFileNew.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileNew.Text = "New";
            this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // cTRLNToolStripMenuItem
            // 
            this.cTRLNToolStripMenuItem.Name = "cTRLNToolStripMenuItem";
            this.cTRLNToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cTRLNToolStripMenuItem.Text = "Shortcut [CTRL +  N]";
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileOpen.Text = "Open";
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileSave.Text = "Save";
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileExit.Text = "Exit";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // ToolBarMainForm
            // 
            this.ToolBarMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolBarMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.ToolBarMainForm.Location = new System.Drawing.Point(0, 24);
            this.ToolBarMainForm.Name = "ToolBarMainForm";
            this.ToolBarMainForm.Size = new System.Drawing.Size(790, 31);
            this.ToolBarMainForm.TabIndex = 1;
            this.ToolBarMainForm.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // ImageListToolBar
            // 
            this.ImageListToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListToolBar.ImageStream")));
            this.ImageListToolBar.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListToolBar.Images.SetKeyName(0, "directory_open.png");
            this.ImageListToolBar.Images.SetKeyName(1, "plus_green.png");
            this.ImageListToolBar.Images.SetKeyName(2, "yes.png");
            // 
            // StatusBarMainForm
            // 
            this.StatusBarMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusBarMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripProgressBar2});
            this.StatusBarMainForm.Location = new System.Drawing.Point(0, 420);
            this.StatusBarMainForm.Name = "StatusBarMainForm";
            this.StatusBarMainForm.ShowItemToolTips = true;
            this.StatusBarMainForm.Size = new System.Drawing.Size(790, 22);
            this.StatusBarMainForm.TabIndex = 2;
            this.StatusBarMainForm.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "OpenFileDialog";
            this.openFileDialog.Filter = "Text files(*.txt)|*.txt";
            // 
            // TextEditorDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.StatusBarMainForm);
            this.Controls.Add(this.ToolBarMainForm);
            this.Controls.Add(this.MenuMainForm);
            this.IsMdiContainer = true;
            this.Name = "TextEditorDemo";
            this.Text = "MDI Text Editor";
            this.Load += new System.EventHandler(this.TextEditorDemo_Load);
            this.MenuMainForm.ResumeLayout(false);
            this.MenuMainForm.PerformLayout();
            this.ToolBarMainForm.ResumeLayout(false);
            this.ToolBarMainForm.PerformLayout();
            this.StatusBarMainForm.ResumeLayout(false);
            this.StatusBarMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMainForm;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolBarMainForm;
        private System.Windows.Forms.ImageList ImageListToolBar;
        private System.Windows.Forms.StatusStrip StatusBarMainForm;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem cTRLNToolStripMenuItem;
    }
}

