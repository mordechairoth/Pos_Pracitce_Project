using ApplicationLayer.Product;
using System;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class NewProductCategory : Form
    {
        private readonly NewProductCategoryHandler addCategoryHandler;
        public event EventHandler NewProductCatecorySaved;
        public NewProductCategory()
        {
            InitializeComponent();
            addCategoryHandler = new NewProductCategoryHandler();
            addCategoryHandler.NewEntitySavedEventHandler += (sender, args) => { NewProductCatecorySaved?.Invoke(sender, args); };
            addCategoryHandler.NewEntitySavedEventHandler += (sender, args) => { MessageBox.Show("Saved!"); };
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addCategoryHandler.Save();
            Close();
            Dispose();
        }

        private void categoryNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addCategoryHandler.Entity.Name = categoryNameTextBox.Text;
        }

        private void categoryDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            addCategoryHandler.Entity.Description = categoryDescriptionTextBox.Text;   
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
