
namespace WinFormsUI
{
    partial class NewProductForm
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
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.barCodeLabel = new System.Windows.Forms.Label();
            this.barCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(475, 432);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 46);
            this.saveButton.TabIndex = 71;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(232, 432);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 46);
            this.cancelButton.TabIndex = 70;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enterInfoLabel
            // 
            this.enterInfoLabel.AutoSize = true;
            this.enterInfoLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterInfoLabel.Location = new System.Drawing.Point(302, 25);
            this.enterInfoLabel.Name = "enterInfoLabel";
            this.enterInfoLabel.Size = new System.Drawing.Size(236, 37);
            this.enterInfoLabel.TabIndex = 69;
            this.enterInfoLabel.Text = "Enter Product Info:";
            // 
            // companyDescriptionLabel
            // 
            this.companyDescriptionLabel.AutoSize = true;
            this.companyDescriptionLabel.Location = new System.Drawing.Point(126, 173);
            this.companyDescriptionLabel.Name = "companyDescriptionLabel";
            this.companyDescriptionLabel.Size = new System.Drawing.Size(85, 20);
            this.companyDescriptionLabel.TabIndex = 68;
            this.companyDescriptionLabel.Text = "Description";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(162, 111);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(49, 20);
            this.companyNameLabel.TabIndex = 67;
            this.companyNameLabel.Text = "Name";
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(232, 170);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(403, 27);
            this.productDescriptionTextBox.TabIndex = 66;
            this.productDescriptionTextBox.TextChanged += new System.EventHandler(this.productDescriptionTextBox_TextChanged);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(232, 104);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(403, 27);
            this.productNameTextBox.TabIndex = 65;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(232, 305);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(403, 28);
            this.categoryComboBox.TabIndex = 72;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(232, 363);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(403, 28);
            this.companyComboBox.TabIndex = 73;
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(42, 366);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(169, 20);
            this.companyLabel.TabIndex = 74;
            this.companyLabel.Text = "Company (Manufacture)";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(142, 305);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 20);
            this.categoryLabel.TabIndex = 75;
            this.categoryLabel.Text = "Category";
            // 
            // barCodeLabel
            // 
            this.barCodeLabel.AutoSize = true;
            this.barCodeLabel.Location = new System.Drawing.Point(126, 247);
            this.barCodeLabel.Name = "barCodeLabel";
            this.barCodeLabel.Size = new System.Drawing.Size(70, 20);
            this.barCodeLabel.TabIndex = 77;
            this.barCodeLabel.Text = "Bar Code";
            // 
            // barCodeTextBox
            // 
            this.barCodeTextBox.Location = new System.Drawing.Point(232, 244);
            this.barCodeTextBox.Name = "barCodeTextBox";
            this.barCodeTextBox.Size = new System.Drawing.Size(403, 27);
            this.barCodeTextBox.TabIndex = 76;
            this.barCodeTextBox.TextChanged += new System.EventHandler(this.barCodeTextBox_TextChanged);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 557);
            this.Controls.Add(this.barCodeLabel);
            this.Controls.Add(this.barCodeTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterInfoLabel);
            this.Controls.Add(this.companyDescriptionLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label enterInfoLabel;
        private System.Windows.Forms.Label companyDescriptionLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label barCodeLabel;
        private System.Windows.Forms.TextBox barCodeTextBox;
    }
}