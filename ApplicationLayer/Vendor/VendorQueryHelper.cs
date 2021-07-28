using POS.Repositories;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLayer.Vendor
{
    public static class VendorQueryHelper
    {
        public static IEnumerable<VendorVm> GetAllVendors()
        {
            VendorRepository vendorRepository = new VendorRepository();
            return vendorRepository.All();
        }

        
    }

}
