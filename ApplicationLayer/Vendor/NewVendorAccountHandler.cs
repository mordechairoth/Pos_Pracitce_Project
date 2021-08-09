using POS.Repositories;
using POS.ViewModels.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLayer.Vendor
{
    public class NewVendorAccountHandler : NewEntityHandler<VendorAccountVm, VendorAccountRepository>
    {
       
        public override void Save()
        {
            Entity.AccountNumber = GetRandomNumberString();
            base.Save();
        }

        

        private string GetRandomNumberString()
        {
            return new Random().Next().ToString();
        }
    }
}
