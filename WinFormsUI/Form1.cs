using ApplicationLayer.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class StartingScreenForm : Form
    {
       
        public StartingScreenForm()
        {
            InitializeComponent();
            BindVendorsToVendorsDataGridView();
        }

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            var addVendorForm = new AddVendorForm();
            addVendorForm.NewVendorSavedEventHandler += OnNewVendorSaved;
            addVendorForm.Show();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {

        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddVendorAccountForm vendorAccountForm = new AddVendorAccountForm();
            vendorAccountForm.Show();
        }

        private void vendorAccountsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnNewVendorSaved(object sender, EventArgs e)
        {
            BindVendorsToVendorsDataGridView();
        }
        private void BindVendorsToVendorsDataGridView()
        {
            var bindingSource = new BindingSource
            {
                DataSource = VendorQueryHelper.GetAllVendors()
            }; 
            vendorsDataGridView.DataSource = bindingSource;
        }
    }
}
