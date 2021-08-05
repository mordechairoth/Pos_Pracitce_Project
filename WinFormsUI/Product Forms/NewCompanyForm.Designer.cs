
namespace WinFormsUI
{
    partial class NewCompanyForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enterInfoLabel = new System.Windows.Forms.Label();
            this.companyDescriptionLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneExtensionLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneExtensionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(538, 510);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 46);
            this.saveButton.TabIndex = 64;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(157, 510);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 46);
            this.cancelButton.TabIndex = 63;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enterInfoLabel
            // 
            this.enterInfoLabel.AutoSize = true;
            this.enterInfoLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterInfoLabel.Location = new System.Drawing.Point(277, 10);
            this.enterInfoLabel.Name = "enterInfoLabel";
            this.enterInfoLabel.Size = new System.Drawing.Size(258, 37);
            this.enterInfoLabel.TabIndex = 62;
            this.enterInfoLabel.Text = "Enter Company Info:";
            // 
            // companyDescriptionLabel
            // 
            this.companyDescriptionLabel.AutoSize = true;
            this.companyDescriptionLabel.Location = new System.Drawing.Point(51, 162);
            this.companyDescriptionLabel.Name = "companyDescriptionLabel";
            this.companyDescriptionLabel.Size = new System.Drawing.Size(85, 20);
            this.companyDescriptionLabel.TabIndex = 61;
            this.companyDescriptionLabel.Text = "Description";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(76, 96);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(49, 20);
            this.companyNameLabel.TabIndex = 60;
            this.companyNameLabel.Text = "Name";
            // 
            // companyDescriptionTextBox
            // 
            this.companyDescriptionTextBox.Location = new System.Drawing.Point(157, 155);
            this.companyDescriptionTextBox.Name = "companyDescriptionTextBox";
            this.companyDescriptionTextBox.Size = new System.Drawing.Size(541, 27);
            this.companyDescriptionTextBox.TabIndex = 59;
            this.companyDescriptionTextBox.TextChanged += new System.EventHandler(this.companyDescriptionTextBox_TextChanged);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(157, 89);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(541, 27);
            this.companyNameTextBox.TabIndex = 58;
            this.companyNameTextBox.TextChanged += new System.EventHandler(this.companyNameTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(65, 460);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 80;
            this.emailLabel.Text = "Email";
            // 
            // phoneExtensionLabel
            // 
            this.phoneExtensionLabel.AutoSize = true;
            this.phoneExtensionLabel.Location = new System.Drawing.Point(428, 403);
            this.phoneExtensionLabel.Name = "phoneExtensionLabel";
            this.phoneExtensionLabel.Size = new System.Drawing.Size(117, 20);
            this.phoneExtensionLabel.TabIndex = 79;
            this.phoneExtensionLabel.Text = "Phone Extension";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(65, 407);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(50, 20);
            this.phoneLabel.TabIndex = 78;
            this.phoneLabel.Text = "Phone";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(304, 330);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(43, 20);
            this.stateLabel.TabIndex = 77;
            this.stateLabel.Text = "State";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(353, 327);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(125, 27);
            this.stateTextBox.TabIndex = 76;
            this.stateTextBox.TextChanged += new System.EventHandler(this.stateTextBox_TextChanged);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(493, 330);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(31, 20);
            this.zipLabel.TabIndex = 75;
            this.zipLabel.Text = "Zip";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(573, 327);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(125, 27);
            this.zipTextBox.TabIndex = 74;
            this.zipTextBox.TextChanged += new System.EventHandler(this.zipTextBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(65, 330);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(34, 20);
            this.cityLabel.TabIndex = 73;
            this.cityLabel.Text = "City";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(51, 263);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(74, 20);
            this.address2Label.TabIndex = 72;
            this.address2Label.Text = "Address 2";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(157, 263);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(541, 27);
            this.address2TextBox.TabIndex = 71;
            this.address2TextBox.TextChanged += new System.EventHandler(this.address2TextBox_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(51, 208);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 20);
            this.addressLabel.TabIndex = 70;
            this.addressLabel.Text = "Address";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(157, 327);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(125, 27);
            this.cityTextBox.TabIndex = 69;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(157, 457);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(541, 27);
            this.emailTextBox.TabIndex = 68;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(157, 400);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(246, 27);
            this.phoneTextBox.TabIndex = 67;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(157, 208);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(541, 27);
            this.addressTextBox.TabIndex = 66;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // phoneExtensionTextBox
            // 
            this.phoneExtensionTextBox.Location = new System.Drawing.Point(551, 400);
            this.phoneExtensionTextBox.Name = "phoneExtensionTextBox";
            this.phoneExtensionTextBox.Size = new System.Drawing.Size(147, 27);
            this.phoneExtensionTextBox.TabIndex = 65;
            this.phoneExtensionTextBox.TextChanged += new System.EventHandler(this.phoneExtensionTextBox_TextChanged);
            // 
            // NewCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 578);
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
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneExtensionTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterInfoLabel);
            this.Controls.Add(this.companyDescriptionLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyDescriptionTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Name = "NewCompanyForm";
            this.Text = "NewCompanyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label enterInfoLabel;
        private System.Windows.Forms.Label companyDescriptionLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyDescriptionTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneExtensionLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneExtensionTextBox;
    }
}