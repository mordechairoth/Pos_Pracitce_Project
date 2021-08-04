using POS.Repositories;
using POS.ViewModels.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public event EventHandler NewVendorAccountSaved;
        public bool IsSaved { get; private set; }

        public void Save()
        {
            if (IsSaved)
            {
                throw new Exception("Item is already saved cannot save twice.");
            }

            VendorAccount.AccountNumber = GetRandomNumberAsString();
            var vendorAccountRepository = new VendorAccountRepository();
            vendorAccountRepository.Add(VendorAccount);
            IsSaved = true;
            OnNewVendorAccountSaved();
        }

        private void OnNewVendorAccountSaved()
        {
            NewVendorAccountSaved?.Invoke(this, EventArgs.Empty);
        }
        private string GetRandomNumberAsString()
        {
            return new Random(new Guid().ToString().Select(x => (int)x).Sum()).Next().ToString();
        }
    }
}
