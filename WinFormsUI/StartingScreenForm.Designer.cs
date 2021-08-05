
namespace WinFormsUI
{
    partial class StartingScreenForm
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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.gridViewTabControl = new System.Windows.Forms.TabControl();
            this.vendorsTabPage = new System.Windows.Forms.TabPage();
            this.vendorsDataGridView = new System.Windows.Forms.DataGridView();
            this.vendorAccountsTabPage = new System.Windows.Forms.TabPage();
            this.vendorAccountsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addProductCategoryButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox.SuspendLayout();
            this.gridViewTabControl.SuspendLayout();
            this.vendorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).BeginInit();
            this.vendorAccountsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorAccountsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(0, 249);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(194, 50);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(0, 147);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(194, 50);
            this.addAccountButton.TabIndex = 1;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // gridViewTabControl
            // 
            this.gridViewTabControl.Controls.Add(this.vendorsTabPage);
            this.gridViewTabControl.Controls.Add(this.vendorAccountsTabPage);
            this.gridViewTabControl.Location = new System.Drawing.Point(251, 113);
            this.gridViewTabControl.Name = "gridViewTabControl";
            this.gridViewTabControl.SelectedIndex = 0;
            this.gridViewTabControl.Size = new System.Drawing.Size(960, 329);
            this.gridViewTabControl.TabIndex = 2;
            // 
            // vendorsTabPage
            // 
            this.vendorsTabPage.Controls.Add(this.vendorsDataGridView);
            this.vendorsTabPage.Location = new System.Drawing.Point(4, 29);
            this.vendorsTabPage.Name = "vendorsTabPage";
            this.vendorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vendorsTabPage.Size = new System.Drawing.Size(952, 296);
            this.vendorsTabPage.TabIndex = 0;
            this.vendorsTabPage.Text = "Vendors";
            this.vendorsTabPage.UseVisualStyleBackColor = true;
            // 
            // vendorsDataGridView
            // 
            this.vendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.vendorsDataGridView.Name = "vendorsDataGridView";
            this.vendorsDataGridView.RowHeadersWidth = 51;
            this.vendorsDataGridView.RowTemplate.Height = 29;
            this.vendorsDataGridView.Size = new System.Drawing.Size(950, 287);
            this.vendorsDataGridView.TabIndex = 0;
            this.vendorsDataGridView.Click += VendorsDataGridView_Click;
            // 
            // vendorAccountsTabPage
            // 
            this.vendorAccountsTabPage.Controls.Add(this.vendorAccountsGridView);
            this.vendorAccountsTabPage.Location = new System.Drawing.Point(4, 29);
            this.vendorAccountsTabPage.Name = "vendorAccountsTabPage";
            this.vendorAccountsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vendorAccountsTabPage.Size = new System.Drawing.Size(952, 296);
            this.vendorAccountsTabPage.TabIndex = 1;
            this.vendorAccountsTabPage.Text = "Vendor Accounts";
            this.vendorAccountsTabPage.UseVisualStyleBackColor = true;
            // 
            // vendorAccountsGridView
            // 
            this.vendorAccountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorAccountsGridView.Location = new System.Drawing.Point(3, 5);
            this.vendorAccountsGridView.Name = "vendorAccountsGridView";
            this.vendorAccountsGridView.RowHeadersWidth = 51;
            this.vendorAccountsGridView.RowTemplate.Height = 29;
            this.vendorAccountsGridView.Size = new System.Drawing.Size(1020, 287);
            this.vendorAccountsGridView.TabIndex = 1;
            this.vendorAccountsGridView.Click += VendorAccountsGridView_Click;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.addProductCategoryButton);
            this.groupBox1.Location = new System.Drawing.Point(1305, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addProductCategoryButton
            // 
            this.addProductCategoryButton.Location = new System.Drawing.Point(0, 16);
            this.addProductCategoryButton.Name = "addProductCategoryButton";
            this.addProductCategoryButton.Size = new System.Drawing.Size(194, 50);
            this.addProductCategoryButton.TabIndex = 0;
            this.addProductCategoryButton.Text = "Add Product Category";
            this.addProductCategoryButton.UseVisualStyleBackColor = true;
            this.addProductCategoryButton.Click += new System.EventHandler(this.addProductCategoryButton_Click);
            // 
            // StartingScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridViewTabControl);
            this.Controls.Add(this.OptionsGroupBox);
            this.Name = "StartingScreenForm";
            this.Text = "StartingScreenForm";
            this.OptionsGroupBox.ResumeLayout(false);
            this.gridViewTabControl.ResumeLayout(false);
            this.vendorsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).EndInit();
            this.vendorAccountsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendorAccountsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVendorButton;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.TabControl gridViewTabControl;
        private System.Windows.Forms.TabPage vendorsTabPage;
        private System.Windows.Forms.DataGridView vendorsDataGridView;
        private System.Windows.Forms.TabPage vendorAccountsTabPage;
        private System.Windows.Forms.DataGridView vendorAccountsGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addProductCategoryButton;
    }
}

