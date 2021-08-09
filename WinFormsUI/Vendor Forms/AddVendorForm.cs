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
            vendorHandler.NewEntitySavedEventHandler += (sender, args) => { NewVendorSavedEventHandler?.Invoke(sender, args); };
            vendorHandler.NewEntitySavedEventHandler += (sender, args) => { MessageBox.Show($"Saved {((NewVendorHandler)sender).Entity.Name}"); };
        }

        private void phoneExtensionTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.PhoneExtension = phoneExtensionTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lastContactName_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.ContactLastName = lastContactNameTextBox.Text;
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
            vendorHandler.Entity.Name = vendorNameTextBox.Text;
        }

        private void firstContactNameTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.ContactFirstName = firstContactNameTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.Address = addressTextBox.Text;
        }

        private void address2TextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.Address2 = address2TextBox.Text;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.City = cityTextBox.Text;
        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.State = stateTextBox.Text;
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.Zip = zipTextBox.Text;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.Phone = phoneTextBox.Text;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorHandler.Entity.Email = emailTextBox.Text;
        }

        protected virtual void OnNewVendorSaved(object sender, EventArgs args)
        {
            NewVendorSavedEventHandler?.Invoke(sender, args);
        }


       
    }
}
