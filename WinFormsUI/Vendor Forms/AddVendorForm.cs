using ApplicationLayer.Vendor;
using System;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class AddVendorForm : Form
    {
        public event EventHandler NewVendorSavedEventHandler;
        private readonly NewVendorHandler vendorHandler;
       
        public AddVendorForm()
        {
            InitializeComponent();
            vendorHandler = new NewVendorHandler();
            vendorHandler.NewVendorSavedEventHandler += (sender, args) => { NewVendorSavedEventHandler?.Invoke(sender, args); };
            vendorHandler.NewVendorSavedEventHandler += (sender, args) => { MessageBox.Show($"Saved {((NewVendorHandler)sender).Vendor.Name}"); };
        }

        private void phoneExtensionTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.PhoneExtension = phoneExtensionTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lastContactName_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.ContactLastName = lastContactNameTextBox.Text;
        }

        private void AddVendorForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            vendorHandler.Save();
            Close();
        }

        private void vendorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.Name = vendorNameTextBox.Text;
        }

        private void firstContactNameTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.ContactFirstName = firstContactNameTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.Address = addressTextBox.Text;
        }

        private void address2TextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.Address2 = address2TextBox.Text;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.City = cityTextBox.Text;
        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.State = stateTextBox.Text;
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.Zip = zipTextBox.Text;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.Phone = phoneTextBox.Text;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Vendor.Email = emailTextBox.Text;
        }

        protected virtual void OnNewVendorSaved(object sender, EventArgs args)
        {
            NewVendorSavedEventHandler?.Invoke(sender, args);
        }


       
    }
}
