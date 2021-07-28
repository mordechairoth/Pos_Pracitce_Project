using ApplicationLayer.Vendor;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class AddVendorAccountForm : Form
    {
        private readonly NewVendorAccountHandler _vendorAccountHandler;
        private readonly IEnumerable<VendorVm> _vendorVms;
        public AddVendorAccountForm()
        {
            InitializeComponent();
            _vendorAccountHandler = new NewVendorAccountHandler();
            _vendorVms = VendorQueryHelper.GetAllVendors();
            vendorComboBox.Items.AddRange(_vendorVms.Select(x => x.Name).ToArray());
            vendorComboBox.Items.Add("Add New Vendor...");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _vendorAccountHandler.Save();
            MessageBox.Show("Account Saved!");
            Close();
        }

        private void accountNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _vendorAccountHandler.VendorAccount.AccountName = accountNameTextBox.Text;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            _vendorAccountHandler.VendorAccount.Email = emailTextBox.Text;
        }

        private void vendorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vendorComboBox.SelectedIndex < vendorComboBox.Items.Count - 1)
            {
                _vendorAccountHandler.VendorAccount.VendorId = _vendorVms.ElementAt(vendorComboBox.SelectedIndex).VendorId;
            }
            else
            {
                AddVendorForm vendorForm = new AddVendorForm();
                vendorForm.Show();
                Close();
            }
        }
    }
}
