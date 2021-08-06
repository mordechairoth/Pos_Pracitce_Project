using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels.Product
{
    public class ProductVm
    {
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public int? ProductCatagoryId { get; set; }

        [NotMappedToEntityClass]
        public ProductCategoryVm ProductCategory { get; set; }
        public int? CompanyId { get; set; }

        [NotMappedToEntityClass]
        public CompanyVm Company { get; set; }
        public DateTime CreatedOn { get; internal set; }
    }
}
