using System;

namespace POS.ViewModels
{
    public class VendorVm
    {
        public int VendorId { get; internal set; }
        public string Name { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
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
