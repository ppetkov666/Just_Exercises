namespace _09___
{
    partial class fMainForm
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
            this.tbTabControl = new System.Windows.Forms.TabControl();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.lbLabelSelectItem = new System.Windows.Forms.Label();
            this.CheckedListBoxItems = new System.Windows.Forms.CheckedListBox();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.tabPageShipping = new System.Windows.Forms.TabPage();
            this.CheckBoxTrackShipping = new System.Windows.Forms.CheckBox();
            this.GroupBoxShippingMethod = new System.Windows.Forms.GroupBox();
            this.RadioButtonFedEx = new System.Windows.Forms.RadioButton();
            this.RadioButtonDHL = new System.Windows.Forms.RadioButton();
            this.RadioButtonMail = new System.Windows.Forms.RadioButton();
            this.pbPanelButtons = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.tbTabControl.SuspendLayout();
            this.tabPageItems.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.tabPageShipping.SuspendLayout();
            this.GroupBoxShippingMethod.SuspendLayout();
            this.pbPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTabControl
            // 
            this.tbTabControl.Controls.Add(this.tabPageItems);
            this.tbTabControl.Controls.Add(this.tabPageAddress);
            this.tbTabControl.Controls.Add(this.tabPageShipping);
            this.tbTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTabControl.Location = new System.Drawing.Point(0, 0);
            this.tbTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTabControl.Multiline = true;
            this.tbTabControl.Name = "tbTabControl";
            this.tbTabControl.SelectedIndex = 0;
            this.tbTabControl.Size = new System.Drawing.Size(813, 451);
            this.tbTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbTabControl.TabIndex = 0;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.lbLabelSelectItem);
            this.tabPageItems.Controls.Add(this.CheckedListBoxItems);
            this.tabPageItems.Location = new System.Drawing.Point(4, 31);
            this.tabPageItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageItems.Size = new System.Drawing.Size(805, 416);
            this.tabPageItems.TabIndex = 0;
            this.tabPageItems.Text = "Items";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // lbLabelSelectItem
            // 
            this.lbLabelSelectItem.AutoSize = true;
            this.lbLabelSelectItem.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelSelectItem.Location = new System.Drawing.Point(14, 11);
            this.lbLabelSelectItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLabelSelectItem.Name = "lbLabelSelectItem";
            this.lbLabelSelectItem.Size = new System.Drawing.Size(463, 30);
            this.lbLabelSelectItem.TabIndex = 1;
            this.lbLabelSelectItem.Text = "Select Items to Order( Press Double Click )";
            // 
            // CheckedListBoxItems
            // 
            this.CheckedListBoxItems.FormattingEnabled = true;
            this.CheckedListBoxItems.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5",
            "Item 6",
            "Item 7"});
            this.CheckedListBoxItems.Location = new System.Drawing.Point(0, 52);
            this.CheckedListBoxItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckedListBoxItems.Name = "CheckedListBoxItems";
            this.CheckedListBoxItems.Size = new System.Drawing.Size(800, 188);
            this.CheckedListBoxItems.TabIndex = 0;
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.Controls.Add(this.TextBoxAddress);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 31);
            this.tabPageAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAddress.Size = new System.Drawing.Size(805, 416);
            this.tabPageAddress.TabIndex = 1;
            this.tabPageAddress.Text = "Address";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxAddress.Location = new System.Drawing.Point(4, 5);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(797, 406);
            this.TextBoxAddress.TabIndex = 0;
            // 
            // tabPageShipping
            // 
            this.tabPageShipping.Controls.Add(this.CheckBoxTrackShipping);
            this.tabPageShipping.Controls.Add(this.GroupBoxShippingMethod);
            this.tabPageShipping.Location = new System.Drawing.Point(4, 31);
            this.tabPageShipping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageShipping.Name = "tabPageShipping";
            this.tabPageShipping.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageShipping.Size = new System.Drawing.Size(805, 416);
            this.tabPageShipping.TabIndex = 2;
            this.tabPageShipping.Text = "Shipping";
            this.tabPageShipping.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTrackShipping
            // 
            this.CheckBoxTrackShipping.AutoSize = true;
            this.CheckBoxTrackShipping.Location = new System.Drawing.Point(14, 200);
            this.CheckBoxTrackShipping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBoxTrackShipping.Name = "CheckBoxTrackShipping";
            this.CheckBoxTrackShipping.Size = new System.Drawing.Size(146, 26);
            this.CheckBoxTrackShipping.TabIndex = 1;
            this.CheckBoxTrackShipping.Text = "Track shipping";
            this.CheckBoxTrackShipping.UseVisualStyleBackColor = true;
            // 
            // GroupBoxShippingMethod
            // 
            this.GroupBoxShippingMethod.Controls.Add(this.RadioButtonFedEx);
            this.GroupBoxShippingMethod.Controls.Add(this.RadioButtonDHL);
            this.GroupBoxShippingMethod.Controls.Add(this.RadioButtonMail);
            this.GroupBoxShippingMethod.Location = new System.Drawing.Point(12, 28);
            this.GroupBoxShippingMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxShippingMethod.Name = "GroupBoxShippingMethod";
            this.GroupBoxShippingMethod.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxShippingMethod.Size = new System.Drawing.Size(300, 154);
            this.GroupBoxShippingMethod.TabIndex = 0;
            this.GroupBoxShippingMethod.TabStop = false;
            this.GroupBoxShippingMethod.Text = "Select shipping method";
            // 
            // RadioButtonFedEx
            // 
            this.RadioButtonFedEx.AutoSize = true;
            this.RadioButtonFedEx.Location = new System.Drawing.Point(10, 106);
            this.RadioButtonFedEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButtonFedEx.Name = "RadioButtonFedEx";
            this.RadioButtonFedEx.Size = new System.Drawing.Size(79, 26);
            this.RadioButtonFedEx.TabIndex = 2;
            this.RadioButtonFedEx.TabStop = true;
            this.RadioButtonFedEx.Text = "Fedex";
            this.RadioButtonFedEx.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDHL
            // 
            this.RadioButtonDHL.AutoSize = true;
            this.RadioButtonDHL.Location = new System.Drawing.Point(10, 69);
            this.RadioButtonDHL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButtonDHL.Name = "RadioButtonDHL";
            this.RadioButtonDHL.Size = new System.Drawing.Size(67, 26);
            this.RadioButtonDHL.TabIndex = 1;
            this.RadioButtonDHL.TabStop = true;
            this.RadioButtonDHL.Text = "DHL";
            this.RadioButtonDHL.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMail
            // 
            this.RadioButtonMail.AutoSize = true;
            this.RadioButtonMail.Location = new System.Drawing.Point(10, 32);
            this.RadioButtonMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButtonMail.Name = "RadioButtonMail";
            this.RadioButtonMail.Size = new System.Drawing.Size(67, 26);
            this.RadioButtonMail.TabIndex = 0;
            this.RadioButtonMail.TabStop = true;
            this.RadioButtonMail.Text = "Mail";
            this.RadioButtonMail.UseVisualStyleBackColor = true;
            // 
            // pbPanelButtons
            // 
            this.pbPanelButtons.Controls.Add(this.ButtonCancel);
            this.pbPanelButtons.Controls.Add(this.ButtonOK);
            this.pbPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbPanelButtons.Location = new System.Drawing.Point(0, 296);
            this.pbPanelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPanelButtons.Name = "pbPanelButtons";
            this.pbPanelButtons.Size = new System.Drawing.Size(813, 155);
            this.pbPanelButtons.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(555, 43);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(232, 69);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(18, 43);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(232, 69);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(813, 451);
            this.Controls.Add(this.pbPanelButtons);
            this.Controls.Add(this.tbTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fMainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.fMainForm_Load);
            this.tbTabControl.ResumeLayout(false);
            this.tabPageItems.ResumeLayout(false);
            this.tabPageItems.PerformLayout();
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.tabPageShipping.ResumeLayout(false);
            this.tabPageShipping.PerformLayout();
            this.GroupBoxShippingMethod.ResumeLayout(false);
            this.GroupBoxShippingMethod.PerformLayout();
            this.pbPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbTabControl;
        private System.Windows.Forms.Panel pbPanelButtons;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.TabPage tabPageShipping;
        private System.Windows.Forms.Label lbLabelSelectItem;
        private System.Windows.Forms.CheckedListBox CheckedListBoxItems;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.CheckBox CheckBoxTrackShipping;
        private System.Windows.Forms.GroupBox GroupBoxShippingMethod;
        private System.Windows.Forms.RadioButton RadioButtonFedEx;
        private System.Windows.Forms.RadioButton RadioButtonDHL;
        private System.Windows.Forms.RadioButton RadioButtonMail;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
    }
}

