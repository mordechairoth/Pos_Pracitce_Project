using Dapper;
using POS.DbEntities;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.Repositories
{
    public class VendorRepository
    {
        public IEnumerable<VendorVm> All()
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var selectAllSqlQuery = DbHelper.GetSelectAllSqlString("Vendors");
            var vendors = connection.Query<Vendors>(selectAllSqlQuery);

            foreach (var vendor in vendors)
            {
                yield return VendorsToVendorVm(vendor);
            }
        }
        public void Add(VendorVm vendorVm)
        {
            Vendors vendor = VendorVmToVendors(vendorVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString("Vendors", "Name", "ContactFirstName", "ContactLastName", "Address",
                                                                "Address2", "City", "State", "Zip", "Phone", "PhoneExtension", "Email");
            connection.ExecuteScalar(insertSqlCommand, vendor);
        }

        private Vendors VendorVmToVendors(VendorVm vendorVm)
        {
            var vendorVmProperties = vendorVm.GetType().GetProperties();
            Vendors vendors = new Vendors();

            foreach (var property in vendorVmProperties)
            {
                vendors.GetType().GetProperty(property.Name).SetValue(vendors, property.GetValue(vendorVm));
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
