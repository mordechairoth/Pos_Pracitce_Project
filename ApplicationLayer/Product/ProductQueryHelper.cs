using POS.Repositories;
using POS.ViewModels.Product;
using System.Collections.Generic;

namespace ApplicationLayer.Product
{
    public class ProductQueryHelper
    {
        public static IEnumerable<ProductCategoryVm> GetAllProductCategories()
        {
            var productCategoryReposity = new ProductCategoryRepository();
            return productCategoryReposity.All();
        }

        public static IEnumerable<CompanyVm> GetAllCompanies()
        {
            var companyRepository = new CompanyRepository();
            return companyRepository.All();
        }
    }
}
