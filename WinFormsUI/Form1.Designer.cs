
namespace WinFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addVendorButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addVendorButton
            // 
            this.addVendorButton.Location = new System.Drawing.Point(0, 16);
            this.addVendorButton.Name = "addVendorButton";
            this.addVendorButton.Size = new System.Drawing.Size(194, 50);
            this.addVendorButton.TabIndex = 0;
            this.addVendorButton.Text = "Add Vendor";
            this.addVendorButton.UseVisualStyleBackColor = true;
            this.addVendorButton.Click += new System.EventHandler(this.addVendorButton_Click);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.newOrderButton);
            this.OptionsGroupBox.Controls.Add(this.addAccountButton);
            this.OptionsGroupBox.Controls.Add(this.addVendorButton);
            this.OptionsGroupBox.Location = new System.Drawing.Point(12, 97);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(194, 345);
            this.OptionsGroupBox.TabIndex = 1;
            this.OptionsGroupBox.TabStop = false;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(0, 147);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(194, 50);
            this.addAccountButton.TabIndex = 1;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(0, 249);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(194, 50);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 596);
            this.Controls.Add(this.OptionsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.OptionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVendorButton;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button addAccountButton;
    }
}

