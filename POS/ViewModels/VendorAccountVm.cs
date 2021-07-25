using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public class VendorAccountVm
    {
        public int VendorAccountId { get; internal set; }
        public int? VendorId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal CreditAmount { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; internal set; }
    }
}
