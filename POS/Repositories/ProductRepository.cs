using Dapper;
using POS.DbEntities;
using POS.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;


namespace POS.Repositories
{
    public class ProductRepository
    {
        private const string PRODUCS_TABLE_NAME = "Products";
        public void Add(ProductVm productVm)
        {
            Products product = ProductVmToProducts(productVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString(PRODUCS_TABLE_NAME, "Name", "Description", "BarCode", "ProductCatagoryId",
                                                                "CompanyId");
            connection.ExecuteScalar(insertSqlCommand, product);
        }

        public ProductVm Find(int productId)
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var findSqlQuery = DbHelper.GetFindByColumnSqlString(PRODUCS_TABLE_NAME, "ProductId", productId.ToString());
            var product = connection.Query<Products>(findSqlQuery);

            try
            {
                return ProductsToProductVm(product.First());
            }
            catch (Exception)
            {
                throw new KeyNotFoundException($"No Vendor with Id ${productId} found.");
            }
        }

        public IEnumerable<ProductVm> All()
        {
            var products = DbHelper.GetAllRows<Products>(PRODUCS_TABLE_NAME);

            foreach (var product in products)
            {
                yield return ProductsToProductVm(product);
            }
        }

       
        private ProductVm ProductsToProductVm(Products products)
        {
            var productsProperties = products.GetType().GetProperties();
            var productVmPropertyNames = typeof(ProductVm).GetProperties().Select(p => p.Name);
            ProductVm productVm = new ProductVm();

            foreach (var property in productsProperties)
            {
                if (productVmPropertyNames.Contains(property.Name))
                    productVm.GetType().GetProperty(property.Name).SetValue(productVm, property.GetValue(products));
            }

            return productVm;
        }

        private Products ProductVmToProducts(ProductVm productVm)
        {
            var productVmProperties = productVm.GetType().GetProperties();
            Products products = new Products();

            foreach (var property in productVmProperties)
            {
                bool hasNotMappedToEntityClassAttribute = property.GetCustomAttributes(typeof(NotMappedToEntityClassAttribute), false).Length > 0;
                if (!hasNotMappedToEntityClassAttribute)
                {
                    products.GetType().GetProperty(property.Name).SetValue(products, property.GetValue(productVm));
                }
                    
            }

            return products;
        }
    }
}
