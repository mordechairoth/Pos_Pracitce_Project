using POS.Repositories;
using POS.ViewModels.Product;
using System;


namespace ApplicationLayer.Product
{
    public class NewProductHandler
    {
        public NewProductHandler()
        {
            Product = new ProductVm();
        }

        public ProductVm Product { get; set; }
        public event EventHandler NewProductsSavedEventHandler;
        public bool IsSaved { get; set; }

        public void Save()
        {
            var productRepostiry = new ProductRepository();
            productRepostiry.Add(Product);
            IsSaved = true;
            OnNewProductSaved();
        }

        private void OnNewProductSaved()
        {
            NewProductsSavedEventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}
