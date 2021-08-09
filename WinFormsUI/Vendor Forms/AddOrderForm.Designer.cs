
namespace WinFormsUI.Vendor_Forms
{
    partial class AddOrderForm
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
            this.barCodeTextBox = new System.Windows.Forms.TextBox();
            this.barCodeLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.chooseVendorLabel = new System.Windows.Forms.Label();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.orderNumberValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barCodeTextBox
            // 
            this.barCodeTextBox.Location = new System.Drawing.Point(248, 132);
            this.barCodeTextBox.Name = "barCodeTextBox";
            this.barCodeTextBox.Size = new System.Drawing.Size(473, 27);
            this.barCodeTextBox.TabIndex = 0;
            // 
            // barCodeLabel
            // 
            this.barCodeLabel.AutoSize = true;
            this.barCodeLabel.Location = new System.Drawing.Point(111, 135);
            this.barCodeLabel.Name = "barCodeLabel";
            this.barCodeLabel.Size = new System.Drawing.Size(131, 20);
            this.barCodeLabel.TabIndex = 1;
            this.barCodeLabel.Text = "ENTER BAR CODE:";
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 20;
            this.cartListBox.Items.AddRange(new object[] {
            "hi what going on over here",
            "right now I\'m writing code",
            "the code I write is text"});
            this.cartListBox.Location = new System.Drawing.Point(727, 132);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(304, 304);
            this.cartListBox.TabIndex = 2;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(248, 186);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(473, 29);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.Location = new System.Drawing.Point(248, 80);
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(473, 28);
            this.vendorComboBox.TabIndex = 4;
            // 
            // chooseVendorLabel
            // 
            this.chooseVendorLabel.AutoSize = true;
            this.chooseVendorLabel.Location = new System.Drawing.Point(111, 83);
            this.chooseVendorLabel.Name = "chooseVendorLabel";
            this.chooseVendorLabel.Size = new System.Drawing.Size(133, 20);
            this.chooseVendorLabel.TabIndex = 5;
            this.chooseVendorLabel.Text = "CHOOSE VENDOR:";
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(233, 335);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(473, 101);
            this.saveOrderButton.TabIndex = 6;
            this.saveOrderButton.Text = "SAVE ORDER";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(111, 48);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(108, 20);
            this.orderNumberLabel.TabIndex = 7;
            this.orderNumberLabel.Text = "Order Number:";
            // 
            // orderNumberValueLabel
            // 
            this.orderNumberValueLabel.AutoSize = true;
            this.orderNumberValueLabel.Location = new System.Drawing.Point(233, 48);
            this.orderNumberValueLabel.Name = "orderNumberValueLabel";
            this.orderNumberValueLabel.Size = new System.Drawing.Size(0, 20);
            this.orderNumberValueLabel.TabIndex = 8;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 498);
            this.Controls.Add(this.orderNumberValueLabel);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.chooseVendorLabel);
            this.Controls.Add(this.vendorComboBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.barCodeLabel);
            this.Controls.Add(this.barCodeTextBox);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barCodeTextBox;
        private System.Windows.Forms.Label barCodeLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ComboBox vendorComboBox;
        private System.Windows.Forms.Label chooseVendorLabel;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label orderNumberValueLabel;
    }
}