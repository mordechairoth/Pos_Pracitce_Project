using Dapper;
using POS.DbEntities;
using POS.ViewModels.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.Repositories
{
    public class VendorAccountRepository
    {
        private const string VENDOR_ACCOUNTS_TABLE_NAME = "VendorAccounts";
        public IEnumerable<VendorAccountVm> All()
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var selectAllSqlQuery = DbHelper.GetSelectAllSqlString(VENDOR_ACCOUNTS_TABLE_NAME);
            var vendorAccounts = connection.Query<VendorAccounts>(selectAllSqlQuery);

            foreach (var vendorAccount in vendorAccounts)
            {
                yield return VendorAccountsToVendorAccountVm(vendorAccount);
            }
        }

        public VendorAccountVm Find(int vendorAccountId)
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var findSqlQuery = DbHelper.GetFindByColumnSqlString(VENDOR_ACCOUNTS_TABLE_NAME, "VendorAccountId", vendorAccountId.ToString());
            var vendorAccount = connection.Query<VendorAccounts>(findSqlQuery);

            try
            {
                return VendorAccountsToVendorAccountVm(vendorAccount.First());
            }
            catch (Exception)
            {
                throw new KeyNotFoundException($"No Vendor Account with Id ${vendorAccountId} found.");
            }
        }
        public void Add(VendorAccountVm vendorAccountVm)
        {
            VendorAccounts vendorAccount = VendorAccountVmToVendorAccounts(vendorAccountVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString("VendorAccounts", "VendorId", "AccountName", "AccountNumber", "CreditAmount",
                                                                "Email");
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

        private VendorAccountVm VendorAccountsToVendorAccountVm(VendorAccounts vendorAccounts)
        {
            var vendorAccountsProperties = vendorAccounts.GetType().GetProperties();
            var vendorAccountVmPropertyNames = typeof(VendorAccountVm).GetProperties().Select(p => p.Name);
            VendorAccountVm vendorAccountVm = new VendorAccountVm();

            foreach (var property in vendorAccountsProperties)
            {
                if (vendorAccountVmPropertyNames.Contains(property.Name))
                    vendorAccountVm.GetType().GetProperty(property.Name).SetValue(vendorAccountVm, property.GetValue(vendorAccounts));
            }

            return vendorAccountVm;
        }
        
    }
}
