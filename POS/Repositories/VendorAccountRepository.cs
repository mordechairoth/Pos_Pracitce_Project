using Dapper;
using POS.DbEntities;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Repositories
{
    public class VendorAccountRepository
    {
        public void Add(VendorAccountVm vendorAccountVm)
        {
            VendorAccounts vendorAccount = VendorAccountVmToVendorAccounts(vendorAccountVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString("VendorAccounts", "VendorId", "AccountName", "AccountNumber", "CreditAmount",
                                                                "Email", "City", "State", "Zip", "Phone", "PhoneExtension", "Email");
            connection.ExecuteScalar(insertSqlCommand, vendorAccount);
        }
        private VendorAccounts VendorAccountVmToVendorAccounts(VendorAccountVm vendorAccountVm)
        {
            var vendorVmProperties = vendorAccountVm.GetType().GetProperties();
            VendorAccounts vendorAccounts = new VendorAccounts();

            foreach (var property in vendorVmProperties)
            {
                vendorAccounts.GetType().GetProperty(property.Name).SetValue(vendorAccounts, property.GetValue(vendorAccountVm));
            }

            return vendorAccounts;
        }
    }
}
