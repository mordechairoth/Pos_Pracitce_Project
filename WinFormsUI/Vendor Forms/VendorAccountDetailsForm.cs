using ApplicationLayer.Vendor;
using POS.ViewModels.Vendor;
using System;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class VendorAccountDetailsForm : Form
    {
        private readonly VendorAccountVm _vendorAccountVm;
        public VendorAccountDetailsForm()
        {
            InitializeComponent();
        }

        public VendorAccountDetailsForm(int vendorAccountId)
            :this()
        {
            _vendorAccountVm = VendorQueryHelper.FindVendorAccount(vendorAccountId);
            BindVendorAccountDetailsToTextBoxes();
        }

        private void BindVendorAccountDetailsToTextBoxes()
        {
            accountNumberTextBox.Text = _vendorAccountVm.AccountNumber;
            accountNameTextBox.Text = _vendorAccountVm.AccountName;
            vendorNameTextBox.Text = VendorQueryHelper.FindVendor(_vendorAccountVm.VendorId.Value).Name;
            accountCreditTextBox.Text = $"${_vendorAccountVm.CreditAmount}";
            dateCreatedTextBox.Text = _vendorAccountVm.CreatedOn.ToShortDateString();
            emailTextBox.Text = _vendorAccountVm.Email;
        }

        private void vendorInfoButton_Click(object sender, EventArgs e)
        {
            var vendorDetailsForm = new VendorDetailsForm(_vendorAccountVm.VendorId.Value);
            vendorDetailsForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
