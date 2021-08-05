using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels.Product
{
    public class ProductCategoryVm
    {
        public int? ProductCatagoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; internal set; }
    }
}
