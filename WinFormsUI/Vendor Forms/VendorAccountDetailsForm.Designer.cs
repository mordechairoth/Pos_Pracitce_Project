
namespace WinFormsUI
{
    partial class VendorAccountDetailsForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.accountCreditLabel = new System.Windows.Forms.Label();
            this.vendorNameLabel = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.accountCreditTextBox = new System.Windows.Forms.TextBox();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.dateCreatedTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.vendorInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(307, 490);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(216, 43);
            this.closeButton.TabIndex = 73;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(107, 241);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 72;
            this.emailLabel.Text = "Email";
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Location = new System.Drawing.Point(426, 179);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(97, 20);
            this.dateCreatedLabel.TabIndex = 71;
            this.dateCreatedLabel.Text = "Date Created";
            // 
            // accountCreditLabel
            // 
            this.accountCreditLabel.AutoSize = true;
            this.accountCreditLabel.Location = new System.Drawing.Point(104, 182);
            this.accountCreditLabel.Name = "accountCreditLabel";
            this.accountCreditLabel.Size = new System.Drawing.Size(49, 20);
            this.accountCreditLabel.TabIndex = 70;
            this.accountCreditLabel.Text = "Credit";
            // 
            // vendorNameLabel
            // 
            this.vendorNameLabel.AutoSize = true;
            this.vendorNameLabel.Location = new System.Drawing.Point(411, 135);
            this.vendorNameLabel.Name = "vendorNameLabel";
            this.vendorNameLabel.Size = new System.Drawing.Size(100, 20);
            this.vendorNameLabel.TabIndex = 61;
            this.vendorNameLabel.Text = "Vendor Name";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Location = new System.Drawing.Point(46, 135);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(107, 20);
            this.accountNameLabel.TabIndex = 60;
            this.accountNameLabel.Text = "Account Name";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(32, 68);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(121, 20);
            this.accountNumberLabel.TabIndex = 58;
            this.accountNumberLabel.Text = "Account Number";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(159, 238);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(558, 27);
            this.emailTextBox.TabIndex = 56;
            // 
            // accountCreditTextBox
            // 
            this.accountCreditTextBox.Enabled = false;
            this.accountCreditTextBox.Location = new System.Drawing.Point(159, 179);
            this.accountCreditTextBox.Name = "accountCreditTextBox";
            this.accountCreditTextBox.Size = new System.Drawing.Size(246, 27);
            this.accountCreditTextBox.TabIndex = 55;
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Enabled = false;
            this.accountNameTextBox.Location = new System.Drawing.Point(159, 132);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(246, 27);
            this.accountNameTextBox.TabIndex = 54;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.Enabled = false;
            this.vendorNameTextBox.Location = new System.Drawing.Point(514, 132);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(203, 27);
            this.vendorNameTextBox.TabIndex = 53;
            // 
            // dateCreatedTextBox
            // 
            this.dateCreatedTextBox.Enabled = false;
            this.dateCreatedTextBox.Location = new System.Drawing.Point(543, 175);
            this.dateCreatedTextBox.Name = "dateCreatedTextBox";
            this.dateCreatedTextBox.Size = new System.Drawing.Size(174, 27);
            this.dateCreatedTextBox.TabIndex = 51;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Enabled = false;
            this.accountNumberTextBox.Location = new System.Drawing.Point(159, 68);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(558, 27);
            this.accountNumberTextBox.TabIndex = 50;
            // 
            // vendorInfoButton
            // 
            this.vendorInfoButton.Location = new System.Drawing.Point(159, 305);
            this.vendorInfoButton.Name = "vendorInfoButton";
            this.vendorInfoButton.Size = new System.Drawing.Size(558, 43);
            this.vendorInfoButton.TabIndex = 74;
            this.vendorInfoButton.Text = "VENDOR INFO";
            this.vendorInfoButton.UseVisualStyleBackColor = true;
            this.vendorInfoButton.Click += new System.EventHandler(this.vendorInfoButton_Click);
            // 
            // VendorAccountDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 565);
            this.Controls.Add(this.vendorInfoButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dateCreatedLabel);
            this.Controls.Add(this.accountCreditLabel);
            this.Controls.Add(this.vendorNameLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.accountCreditTextBox);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(this.dateCreatedTextBox);
            this.Controls.Add(this.accountNumberTextBox);
            this.Name = "VendorAccountDetailsForm";
            this.Text = "VendorAccountDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dateCreatedLabel;
        private System.Windows.Forms.Label accountCreditLabel;
        private System.Windows.Forms.Label vendorNameLabel;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox accountCreditTextBox;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox dateCreatedTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Button vendorInfoButton;
    }
}