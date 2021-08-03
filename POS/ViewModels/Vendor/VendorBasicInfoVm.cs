using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace POS.ViewModels.Vendor
{
    public class VendorBasicInfoVm
    {
        public VendorBasicInfoVm()
        {

        }

        public VendorBasicInfoVm(VendorVm vendor)
        {
            VendorId = vendor.VendorId;
            VendorName = vendor.Name;
            VendorContactName = vendor.ContactFirstName + " " + vendor.ContactLastName;
            Email = vendor.Email;
        }

        [Browsable(false)]
        public int VendorId { get; set; }
        [DisplayName("Vendor Name")]
        public string VendorName { get; set; }
        [DisplayName("Contact Name")]
        public string VendorContactName { get; set; }
        public string Email { get; set; }
    }
}
