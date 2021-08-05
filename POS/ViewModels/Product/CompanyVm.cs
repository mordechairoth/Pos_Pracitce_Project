using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels.Product
{
    public class CompanyVm
    {
        public int? CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
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
