
namespace WinFormsUI
{
    partial class NewProductCategory
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
            this.categoryDescriptionLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(495, 324);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 46);
            this.saveButton.TabIndex = 64;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(252, 324);
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
            this.enterInfoLabel.Location = new System.Drawing.Point(322, 81);
            this.enterInfoLabel.Name = "enterInfoLabel";
            this.enterInfoLabel.Size = new System.Drawing.Size(252, 37);
            this.enterInfoLabel.TabIndex = 62;
            this.enterInfoLabel.Text = "Enter Category Info:";
            // 
            // categoryDescriptionLabel
            // 
            this.categoryDescriptionLabel.AutoSize = true;
            this.categoryDescriptionLabel.Location = new System.Drawing.Point(146, 229);
            this.categoryDescriptionLabel.Name = "categoryDescriptionLabel";
            this.categoryDescriptionLabel.Size = new System.Drawing.Size(85, 20);
            this.categoryDescriptionLabel.TabIndex = 61;
            this.categoryDescriptionLabel.Text = "Description";
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(182, 167);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(49, 20);
            this.categoryNameLabel.TabIndex = 60;
            this.categoryNameLabel.Text = "Name";
            // 
            // categoryDescriptionTextBox
            // 
            this.categoryDescriptionTextBox.Location = new System.Drawing.Point(252, 226);
            this.categoryDescriptionTextBox.Name = "categoryDescriptionTextBox";
            this.categoryDescriptionTextBox.Size = new System.Drawing.Size(403, 27);
            this.categoryDescriptionTextBox.TabIndex = 59;
            this.categoryDescriptionTextBox.TextChanged += new System.EventHandler(this.categoryDescriptionTextBox_TextChanged);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(252, 160);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(403, 27);
            this.categoryNameTextBox.TabIndex = 58;
            this.categoryNameTextBox.TextChanged += new System.EventHandler(this.categoryNameTextBox_TextChanged);
            // 
            // NewProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterInfoLabel);
            this.Controls.Add(this.categoryDescriptionLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.categoryDescriptionTextBox);
            this.Controls.Add(this.categoryNameTextBox);
            this.Name = "NewProductCategory";
            this.Text = "NewProductC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label enterInfoLabel;
        private System.Windows.Forms.Label categoryDescriptionLabel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox categoryDescriptionTextBox;
        private System.Windows.Forms.TextBox categoryNameTextBox;
    }
}