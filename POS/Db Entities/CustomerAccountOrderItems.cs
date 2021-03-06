// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace POS.DbEntities
{
    public partial class CustomerAccountOrderItems
    {
        [NotMappedWrite]
        public int CustomerAccountOrderItemId { get; set; }
        public int CustomerAccountOrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal PricePaidPerUnit { get; set; }

        [NotMappedWrite]
        public DateTime CreatedOn { get; set; }

        [NotMappedWrite]
        public DateTime UpdatedOn { get; set; }

        [NotMappedWrite]
        public bool IsDeleted { get; set; }

        [NotMappedWrite]
        public virtual CustomerAccountOrders CustomerAccountOrder { get; set; }

        [NotMappedWrite]
        public virtual Products Product { get; set; }
    }
}