using Dapper;
using POS.DbEntities;
using POS.ViewModels.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.Repositories
{
    public class VendorRepository
    {
        private const string VENDORS_TABLE_NAME = "Vendors";
        public IEnumerable<VendorVm> All()
        {
            var vendors = DbHelper.GetAllRows<Vendors>(VENDORS_TABLE_NAME);

            foreach (var vendor in vendors)
            {
                yield return VendorsToVendorVm(vendor);
            }
        }

        public VendorVm Find(int vendorId)
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var findSqlQuery = DbHelper.GetFindByColumnSqlString(VENDORS_TABLE_NAME, "VendorId", vendorId.ToString());
            var vendor = connection.Query<Vendors>(findSqlQuery);

            try
            {
                return VendorsToVendorVm(vendor.First());
            }
            catch (Exception)
            {
                throw new KeyNotFoundException($"No Vendor with Id ${vendorId} found.");
            }
           
        }
        public void Add(VendorVm vendorVm)
        {
            Vendors vendor = VendorVmToVendors(vendorVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString(VENDORS_TABLE_NAME, "Name", "ContactFirstName", "ContactLastName", "Address",
                                                                "Address2", "City", "State", "Zip", "Phone", "PhoneExtension", "Email");
            connection.ExecuteScalar(insertSqlCommand, vendor);
        }

        private Vendors VendorVmToVendors(VendorVm vendorVm)
        {
            var vendorVmProperties = vendorVm.GetType().GetProperties();
            Vendors vendors = new Vendors();

            foreach (var property in vendorVmProperties)
            {
                bool hasNotMappedToEntityClassAttribute = property.GetCustomAttributes(typeof(NotMappedToEntityClassAttribute), false).Length > 0;
                if (!hasNotMappedToEntityClassAttribute)
                {
                     vendors.GetType().GetProperty(property.Name).SetValue(vendors, property.GetValue(vendorVm));
                }
            }

            return vendors;
        }

        private VendorVm VendorsToVendorVm(Vendors vendors)
        {
            var vendorsProperties = vendors.GetType().GetProperties();
            var vendorVmPropertyNames = typeof(VendorVm).GetProperties().Select(p => p.Name);
            VendorVm vendorVm = new VendorVm();

            foreach (var property in vendorsProperties)
            {
                if (vendorVmPropertyNames.Contains(property.Name))
                    vendorVm.GetType().GetProperty(property.Name).SetValue(vendorVm, property.GetValue(vendors));
            }

            return vendorVm;
        }
    }
}
