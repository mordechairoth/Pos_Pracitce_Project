using POS.Repositories;
using POS.ViewModels.Vendor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Vendor
{
    public class NewVendorHandler
    {
        public NewVendorHandler()
        {
            Vendor = new VendorVm();
        }

        public event EventHandler NewVendorSavedEventHandler;
        public VendorVm Vendor { get; }
        public bool IsSaved { get; private set; }

        public void Save()
        {
            if (IsSaved)
            {
                throw new Exception("Vendor Was Already Saved, Cannot Save Twice");
            }

            VendorRepository vendorRepository = new VendorRepository();
            vendorRepository.Add(Vendor);
            IsSaved = true;
            OnNewVendorSaved();
        }

        protected virtual void OnNewVendorSaved()
        {
            NewVendorSavedEventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}
