using ApplicationLayer.Vendor;
using POS.ViewModels.Vendor;
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

        private void VendorsDataGridView_Click(object sender, EventArgs e)
        {
            VendorBasicInfoVm vendor = ((VendorBasicInfoVm)((BindingSource)((DataGridView)sender).DataSource).Current);
            DisplayVendorDetails(vendor);
        }

        private void DisplayVendorDetails(VendorBasicInfoVm vendorBasicInfoVm)
        {
            int vendorId = vendorBasicInfoVm.VendorId;
            var vendorDetailsForm = new VendorDetailsForm(vendorId);
            vendorDetailsForm.Show();
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
            vendorAccountForm.Show();
        }

        private void OnNewVendorSaved(object sender, EventArgs e)
        {
            BindVendorsToVendorsDataGridView();
        }
        private void BindVendorsToVendorsDataGridView()
        {

            var bindingSource = new BindingSource
            {
                DataSource = VendorQueryHelper.GetAllVendorBasicInfoVms()
            }; 
            
            vendorsDataGridView.DataSource = bindingSource;
        }

        
    }
}
