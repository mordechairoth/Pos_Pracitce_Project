using ApplicationLayer.Vendor;
using POS.ViewModels.Vendor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            CustomInitializeComponent();
            BindVendorsToVendorsDataGridView();
            BindVendorAccountsToVendorAccountsGridView();
        }

        private void CustomInitializeComponent()
        {
            vendorsDataGridView.Click += VendorsDataGridView_Click;
            vendorAccountsGridView.Click += VendorAccountsGridView_Click;
        }
        private void VendorsDataGridView_Click(object sender, EventArgs e)
        {

            VendorBasicInfoVm vendor = ((VendorBasicInfoVm)((BindingSource)((DataGridView)sender).DataSource).Current);
            DisplayVendorDetails(vendor.VendorId);
        }

        private void VendorAccountsGridView_Click(object sender, EventArgs e)
        {
            VendorAccountBasicInfoVm vendorAccount = ((VendorAccountBasicInfoVm)((BindingSource)((DataGridView)sender).DataSource).Current);
            DisplayVendorAccountDetails(vendorAccount.VendorAccountId);
        }
        

        private void DisplayVendorDetails(int vendorId)
        {    
            var vendorDetailsForm = new VendorDetailsForm(vendorId);
            vendorDetailsForm.Show();
        }
  
        private void DisplayVendorAccountDetails(int vendorAccountId)
        {
            var vendorAccountDetailsFrom = new VendorAccountDetailsForm(vendorAccountId);
            vendorAccountDetailsFrom.Show();
        }

       

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            var addVendorForm = new AddVendorForm();
            addVendorForm.NewVendorSavedEventHandler += OnNewVendorSaved;
            addVendorForm.Show();
        }
        
        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddVendorAccountForm vendorAccountForm = new AddVendorAccountForm();
            vendorAccountForm.NewVendorAccountSavedEventHandler += OnNewVendorAccountSaved;
            vendorAccountForm.Show();
        }

        private void OnNewVendorSaved(object sender, EventArgs e)
        {
            BindVendorsToVendorsDataGridView();
        }

        private void OnNewVendorAccountSaved(object sender, EventArgs e)
        {
            BindVendorAccountsToVendorAccountsGridView();
        }
        private void BindVendorsToVendorsDataGridView()
        {
            var bindingSource = new BindingSource
            {
                DataSource = VendorQueryHelper.GetAllVendorBasicInfoVms()
            }; 
            
            vendorsDataGridView.DataSource = bindingSource;
        }

        private void BindVendorAccountsToVendorAccountsGridView()
        {
            var bindingSource = new BindingSource
            {
                DataSource = VendorQueryHelper.GetAllVendorAccountBasicInfo()
            };

            vendorAccountsGridView.DataSource = bindingSource;
        }

        private void addProductCategoryButton_Click(object sender, EventArgs e)
        {
            var productCategoryForm = new NewProductCategory();
            productCategoryForm.Show();
            //TODO add the event handler to reload the grid when catagories are displayed
        }

        private void addCompanyButton_Click(object sender, EventArgs e)
        {
            var addCompanyForm = new NewCompanyForm();
            addCompanyForm.Show();
            //TODO add the event handler to reaload the grid when companies are displayed
        }

    }

}
