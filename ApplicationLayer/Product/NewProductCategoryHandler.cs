using POS.Repositories;
using POS.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Product
{
    public class NewProductCategoryHandler
    {
        public NewProductCategoryHandler()
        {
            ProductCategory = new ProductCategoryVm();
        }
        public event EventHandler NewProductSaved;
        public ProductCategoryVm ProductCategory { get;}
        public bool IsSaved { get; private set; }

        public void Save()
        {
            var categoryRepository = new ProductCategoryRepository();
            categoryRepository.Add(ProductCategory);
            IsSaved = true;
            OnNewProductSaved();
        }

        protected virtual void OnNewProductSaved()
        {
            NewProductSaved?.Invoke(this, EventArgs.Empty);
        }
    }
}
