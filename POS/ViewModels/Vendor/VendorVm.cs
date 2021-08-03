using System;
using System.ComponentModel;

namespace POS.ViewModels.Vendor
{
    public class VendorVm
    {
        public int VendorId { get; internal set; }

        [DisplayName("Vendor Name")]
        public string Name { get; set; }

        [DisplayName("First Contact Name")]
        public string ContactFirstName { get; set; }

        [DisplayName("Last Contact Name")]
        public string ContactLastName { get; set; }

        [DisplayName("Contact Name")]
        public string FullContactName => ContactFirstName + " " + ContactLastName;
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string PhoneExtension { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; internal set; }
    }
}
