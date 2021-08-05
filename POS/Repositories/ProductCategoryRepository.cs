using Dapper;
using POS.DbEntities;
using POS.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.Repositories
{
    public class ProductCategoryRepository
    {
        private const string PRODUCT_CATEGORIES_TABLE_NAME = "ProductCatagories";
        public IEnumerable<ProductCategoryVm> All()
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var selectAllSqlQuery = DbHelper.GetSelectAllSqlString(PRODUCT_CATEGORIES_TABLE_NAME);
            var productCategories = connection.Query<ProductCatagories>(selectAllSqlQuery);

            foreach (var productCategory in productCategories)
            {
                yield return ProductCatagoriesToProductCategoryVm(productCategory);
            }
        }

        private ProductCategoryVm ProductCatagoriesToProductCategoryVm(ProductCatagories productCategory)
        {
            var productCatagoriesProperties = productCategory.GetType().GetProperties();
            var productCategoryVmPropertyNames = typeof(ProductCategoryVm).GetProperties().Select(p => p.Name);
            ProductCategoryVm productCategoryVm = new ProductCategoryVm();

            foreach (var property in productCatagoriesProperties)
            {
                if (productCategoryVmPropertyNames.Contains(property.Name))
                    productCategoryVm.GetType().GetProperty(property.Name).SetValue(productCategoryVm, property.GetValue(productCategory));
            }

            return productCategoryVm;
        }

        public ProductCategoryVm Find(int productCategoryId)
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var findSqlQuery = DbHelper.GetFindByColumnSqlString(PRODUCT_CATEGORIES_TABLE_NAME, "ProductCatagoryId", productCategoryId.ToString());
            var productCategory = connection.Query<ProductCatagories>(findSqlQuery);

            try
            {
                return ProductCatagoriesToProductCategoryVm(productCategory.First());
            }
            catch (Exception)
            {
                throw new KeyNotFoundException($"No Vendor with Id ${productCategoryId} found.");
            }

        }
        public void Add(ProductCategoryVm productCategoryVm)
        {
            ProductCatagories productCategory = ProductCategoryVmToProductCatagories(productCategoryVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString(PRODUCT_CATEGORIES_TABLE_NAME, "Name", "Description");
            connection.ExecuteScalar(insertSqlCommand, productCategory);
        }

        private ProductCatagories ProductCategoryVmToProductCatagories(ProductCategoryVm productCategoryVm)
        {
            var productCategoryProperties = productCategoryVm.GetType().GetProperties();
            ProductCatagories productCatagories = new ProductCatagories();

            foreach (var property in productCategoryProperties)
            {
                    productCatagories.GetType().GetProperty(property.Name).SetValue(productCatagories, property.GetValue(productCategoryVm));
            }

            return productCatagories;
        }
    }
}
