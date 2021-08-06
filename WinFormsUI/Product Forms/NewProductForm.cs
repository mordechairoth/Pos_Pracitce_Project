using ApplicationLayer.Product;
using POS.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsUI
{ 
    public partial class NewProductForm : Form
    {
        private readonly NewProductHandler newProductHandler;
        public event EventHandler NewProductSavedEventHandler;
        private readonly IEnumerable<ProductCategoryVm> _productCategoryVms;
        private readonly IEnumerable<CompanyVm> _companyVms;
        public NewProductForm()
        {
            InitializeComponent();
            _productCategoryVms = ProductQueryHelper.GetAllProductCategories();
            _companyVms = ProductQueryHelper.GetAllCompanies();
            categoryComboBox.Items.AddRange(_productCategoryVms.Select(x => x.Name).ToArray());
            categoryComboBox.Items.Add("Add New Category...");

            companyComboBox.Items.AddRange(_companyVms.Select(x => x.Name).ToArray());
            companyComboBox.Items.Add("Add New Company...");

            newProductHandler = new NewProductHandler();
            newProductHandler.NewProductsSavedEventHandler += (sender, args) => { NewProductSavedEventHandler?.Invoke(sender, args); };
            newProductHandler.NewProductsSavedEventHandler += (sender, args) => { MessageBox.Show($"Product {((NewProductHandler)sender).Product.Name} Saved!");};
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            newProductHandler.Product.Name = productNameTextBox.Text;
        }

        private void productDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            newProductHandler.Product.Description = productDescriptionTextBox.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newProductHandler.Save();
            Close();
            Dispose();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex < categoryComboBox.Items.Count - 1)
            {
                newProductHandler.Product.ProductCatagoryId = _productCategoryVms.ElementAt(categoryComboBox.SelectedIndex).ProductCatagoryId;
            }
            else
            {
                NewProductCategory newProductCategory = new NewProductCategory();
                newProductCategory.Show();
                Close();
            }
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companyComboBox.SelectedIndex < companyComboBox.Items.Count - 1)
            {
                newProductHandler.Product.CompanyId = _companyVms.ElementAt(companyComboBox.SelectedIndex).CompanyId;
            }
            else
            {
                NewCompanyForm newCompanyForm = new NewCompanyForm();
                newCompanyForm.Show();
                Close();
            }
        }

        private void barCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            newProductHandler.Product.BarCode = barCodeTextBox.Text;
        }
    }
}
