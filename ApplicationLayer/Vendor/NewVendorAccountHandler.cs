using POS.Repositories;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Vendor
{
    public class NewVendorAccountHandler
    {
        public NewVendorAccountHandler()
        {
            VendorAccount = new VendorAccountVm();
        }

        public  VendorAccountVm VendorAccount { get; }

        public bool IsSaved { get; private set; }

        public void Save()
        {
            if (IsSaved)
            {
                throw new Exception("Item is already saved cannot save twice.");
            }
            
            var vendorAccountRepository = new VendorAccountRepository();
            vendorAccountRepository.Add(VendorAccount);
            IsSaved = true;
        }
    }
}
