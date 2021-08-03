using POS.Repositories;
using POS.ViewModels.Vendor;
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

        public static IEnumerable<VendorBasicInfoVm> GetAllVendorBasicInfoVms()
        {
            return GetAllVendors().Select(x => new VendorBasicInfoVm(x));
        }
        public static VendorVm Find(int vendorId)
        {
            var vendorRepository = new VendorRepository();
            return vendorRepository.Find(vendorId);
        }
    }

}
