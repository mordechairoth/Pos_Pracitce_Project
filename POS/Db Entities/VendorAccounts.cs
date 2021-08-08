﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace POS.DbEntities
{
    public partial class VendorAccounts
    {
        public VendorAccounts()
        {
            VendorAccountOrders = new HashSet<VendorAccountOrders>();
            VendorAccountPayments = new HashSet<VendorAccountPayments>();
        }

        [NotMappedWrite]
        public int VendorAccountId { get; set; }
        public int VendorId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal CreditAmount { get; set; }
        public string Email { get; set; }

        [NotMappedWrite]
        public DateTime CreatedOn { get; set; }

        [NotMappedWrite]
        public DateTime UpdatedOn { get; set; }

        [NotMappedWrite]
        public bool IsDeleted { get; set; }

        [NotMappedWrite]
        public virtual Vendors Vendor { get; set; }

        [NotMappedWrite]
        public virtual ICollection<VendorAccountOrders> VendorAccountOrders { get; set; }

        [NotMappedWrite]
        public virtual ICollection<VendorAccountPayments> VendorAccountPayments { get; set; }
    }
}