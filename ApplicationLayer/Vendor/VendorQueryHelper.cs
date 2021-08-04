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
        public static VendorVm FindVendor(int vendorId)
        {
            var vendorRepository = new VendorRepository();
            return vendorRepository.Find(vendorId);
        }

        public static VendorAccountVm FindVendorAccount(int vendorAccountId)
        {
            var vendorAccountRepository = new VendorAccountRepository();
            return vendorAccountRepository.Find(vendorAccountId);
        }

        public static IEnumerable<VendorAccountBasicInfoVm> GetAllVendorAccountBasicInfo()
        {
            return GetAllVendorAccounts().Select(x => new VendorAccountBasicInfoVm(x));
        }

        public static IEnumerable<VendorAccountVm> GetAllVendorAccounts()
        {
            var vendorAccountRepositry = new VendorAccountRepository();
            return vendorAccountRepositry.All();
        }
    }

}
