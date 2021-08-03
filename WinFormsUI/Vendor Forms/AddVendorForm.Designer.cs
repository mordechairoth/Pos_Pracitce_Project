
namespace WinFormsUI
{
    partial class AddVendorForm
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
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneExtensionTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.lastContactNameTextBox = new System.Windows.Forms.TextBox();
            this.firstContactNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameLabel = new System.Windows.Forms.Label();
            this.contactNameLabel = new System.Windows.Forms.Label();
            this.firstContactName = new System.Windows.Forms.Label();
            this.lastContactName = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneExtensionLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.Location = new System.Drawing.Point(406, 119);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(541, 27);
            this.vendorNameTextBox.TabIndex = 0;
            this.vendorNameTextBox.TextChanged += new System.EventHandler(this.vendorNameTextBox_TextChanged);
            // 
            // phoneExtensionTextBox
            // 
            this.phoneExtensionTextBox.Location = new System.Drawing.Point(800, 434);
            this.phoneExtensionTextBox.Name = "phoneExtensionTextBox";
            this.phoneExtensionTextBox.Size = new System.Drawing.Size(147, 27);
            this.phoneExtensionTextBox.TabIndex = 2;
            this.phoneExtensionTextBox.TextChanged += new System.EventHandler(this.phoneExtensionTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(406, 242);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(541, 27);
            this.addressTextBox.TabIndex = 3;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // lastContactNameTextBox
            // 
            this.lastContactNameTextBox.Location = new System.Drawing.Point(744, 183);
            this.lastContactNameTextBox.Name = "lastContactNameTextBox";
            this.lastContactNameTextBox.Size = new System.Drawing.Size(203, 27);
            this.lastContactNameTextBox.TabIndex = 4;
            this.lastContactNameTextBox.TextChanged += new System.EventHandler(this.lastContactName_TextChanged);
            // 
            // firstContactNameTextBox
            // 
            this.firstContactNameTextBox.Location = new System.Drawing.Point(406, 186);
            this.firstContactNameTextBox.Name = "firstContactNameTextBox";
            this.firstContactNameTextBox.Size = new System.Drawing.Size(246, 27);
            this.firstContactNameTextBox.TabIndex = 5;
            this.firstContactNameTextBox.TextChanged += new System.EventHandler(this.firstContactNameTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(406, 434);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(246, 27);
            this.phoneTextBox.TabIndex = 6;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(406, 491);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(541, 27);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(406, 361);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(125, 27);
            this.cityTextBox.TabIndex = 10;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // vendorNameLabel
            // 
            this.vendorNameLabel.AutoSize = true;
            this.vendorNameLabel.Location = new System.Drawing.Point(406, 76);
            this.vendorNameLabel.Name = "vendorNameLabel";
            this.vendorNameLabel.Size = new System.Drawing.Size(100, 20);
            this.vendorNameLabel.TabIndex = 11;
            this.vendorNameLabel.Text = "Vendor Name";
            // 
            // contactNameLabel
            // 
            this.contactNameLabel.AutoSize = true;
            this.contactNameLabel.Location = new System.Drawing.Point(406, 163);
            this.contactNameLabel.Name = "contactNameLabel";
            this.contactNameLabel.Size = new System.Drawing.Size(104, 20);
            this.contactNameLabel.TabIndex = 12;
            this.contactNameLabel.Text = "Contact Name";
            // 
            // firstContactName
            // 
            this.firstContactName.AutoSize = true;
            this.firstContactName.Location = new System.Drawing.Point(300, 186);
            this.firstContactName.Name = "firstContactName";
            this.firstContactName.Size = new System.Drawing.Size(80, 20);
            this.firstContactName.TabIndex = 13;
            this.firstContactName.Text = "First Name";
            this.firstContactName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastContactName
            // 
            this.lastContactName.AutoSize = true;
            this.lastContactName.Location = new System.Drawing.Point(658, 186);
            this.lastContactName.Name = "lastContactName";
            this.lastContactName.Size = new System.Drawing.Size(79, 20);
            this.lastContactName.TabIndex = 14;
            this.lastContactName.Text = "Last Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(300, 242);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 20);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Address";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(300, 297);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(74, 20);
            this.address2Label.TabIndex = 17;
            this.address2Label.Text = "Address 2";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(406, 297);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(541, 27);
            this.address2TextBox.TabIndex = 16;
            this.address2TextBox.TextChanged += new System.EventHandler(this.address2TextBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(314, 364);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(34, 20);
            this.cityLabel.TabIndex = 18;
            this.cityLabel.Text = "City";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(742, 364);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(31, 20);
            this.zipLabel.TabIndex = 20;
            this.zipLabel.Text = "Zip";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(822, 361);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(125, 27);
            this.zipTextBox.TabIndex = 19;
            this.zipTextBox.TextChanged += new System.EventHandler(this.zipTextBox_TextChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(553, 364);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(43, 20);
            this.stateLabel.TabIndex = 22;
            this.stateLabel.Text = "State";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(602, 361);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(125, 27);
            this.stateTextBox.TabIndex = 21;
            this.stateTextBox.TextChanged += new System.EventHandler(this.stateTextBox_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(314, 441);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(50, 20);
            this.phoneLabel.TabIndex = 23;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneExtensionLabel
            // 
            this.phoneExtensionLabel.AutoSize = true;
            this.phoneExtensionLabel.Location = new System.Drawing.Point(677, 437);
            this.phoneExtensionLabel.Name = "phoneExtensionLabel";
            this.phoneExtensionLabel.Size = new System.Drawing.Size(117, 20);
            this.phoneExtensionLabel.TabIndex = 24;
            this.phoneExtensionLabel.Text = "Phone Extension";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(314, 494);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "Email";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(406, 544);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 46);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(787, 544);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 46);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 622);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneExtensionLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastContactName);
            this.Controls.Add(this.firstContactName);
            this.Controls.Add(this.contactNameLabel);
            this.Controls.Add(this.vendorNameLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.firstContactNameTextBox);
            this.Controls.Add(this.lastContactNameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneExtensionTextBox);
            this.Controls.Add(this.vendorNameTextBox);
            this.Name = "AddVendorForm";
            this.Text = "Add Vendor";
            this.Load += new System.EventHandler(this.AddVendorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox phoneExtensionTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox lastContactNameTextBox;
        private System.Windows.Forms.TextBox firstContactNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label vendorNameLabel;
        private System.Windows.Forms.Label contactNameLabel;
        private System.Windows.Forms.Label firstContactName;
        private System.Windows.Forms.Label lastContactName;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label phoneExtensionLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}