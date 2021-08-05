using ApplicationLayer.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class NewCompanyForm : Form
    {
        private readonly NewCompanyHandler newCompanyHandler;
        public event EventHandler NewCompanySavedEventHandler;
        public NewCompanyForm()
        {
            InitializeComponent();
            newCompanyHandler = new NewCompanyHandler();
            newCompanyHandler.NewCompanySavedEventHandler += (sender, args) => { NewCompanySavedEventHandler?.Invoke(sender, args); };
            newCompanyHandler.NewCompanySavedEventHandler += (sender, args) => { MessageBox.Show("Saved!");};
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.Name = companyNameTextBox.Text;
        }

        private void companyDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.Description = companyDescriptionTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.Address = addressTextBox.Text;
        }

        private void address2TextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.Address2 = address2TextBox.Text;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.City = cityTextBox.Text;
        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.State = stateTextBox.Text;
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.Zip = zipTextBox.Text;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.Phone = phoneTextBox.Text;
        }

        private void phoneExtensionTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.PhoneExtension = phoneExtensionTextBox.Text;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            newCompanyHandler.Company.Email = emailTextBox.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newCompanyHandler.Save();
            Close();
            Dispose();
        }
    }
}
