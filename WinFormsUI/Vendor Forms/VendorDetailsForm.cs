using ApplicationLayer.Vendor;
using POS.ViewModels.Vendor;
using System;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class VendorDetailsForm : Form
    {
        public VendorVm _vendor;
        public VendorDetailsForm()
        {
            InitializeComponent();
        }
        public VendorDetailsForm(int VendorId)
        {
            InitializeComponent();
            _vendor = VendorQueryHelper.FindVendor(VendorId);
            BindVendorDetailsToTextBoxes();
        }

        private void VendorDetails_Load(object sender, EventArgs e)
        {

        }

        private void BindVendorDetailsToTextBoxes()
        {
            vendorNameTextBox.Text = _vendor.Name;
            firstContactNameTextBox.Text = _vendor.ContactFirstName;
            lastContactNameTextBox.Text = _vendor.ContactLastName;
            addressTextBox.Text = _vendor.Address;
            address2TextBox.Text = _vendor.Address2;
            cityTextBox.Text = _vendor.City;
            stateTextBox.Text = _vendor.State;
            zipTextBox.Text = _vendor.Zip;
            phoneTextBox.Text = _vendor.Phone;
            phoneExtensionTextBox.Text = _vendor.PhoneExtension;
            emailTextBox.Text = _vendor.Email;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
