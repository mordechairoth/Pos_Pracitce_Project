using POS.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace POS.ViewModels.Vendor
{
    public class VendorAccountBasicInfoVm
    {
        public VendorAccountBasicInfoVm(VendorAccountVm vendorAccountVm)
        {
            VendorAccountId = vendorAccountVm.VendorAccountId;
            VendorId = vendorAccountVm.VendorId.Value;
            AccountNumber = vendorAccountVm.AccountNumber;
            AccountName = vendorAccountVm.AccountName;
            VendorName = new VendorRepository().Find(VendorId).Name;//Todo refactor this to not make a db call
            Email = vendorAccountVm.Email;
            Credit = $"${vendorAccountVm.CreditAmount}";
        }

        [Browsable(false)]
        public int VendorAccountId { get; set; }

        [Browsable(false)]
        public int VendorId { get; set; }

        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [DisplayName("Account Name")]
        public string AccountName { get; set; }

        [DisplayName("VendorName")]
        public string VendorName { get; set; }

        [DisplayName("Credit")]
        public string Credit { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
