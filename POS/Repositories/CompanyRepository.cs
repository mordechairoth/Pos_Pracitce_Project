using POS.ViewModels;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using POS.DbEntities;
using System.Linq;

namespace POS.Repositories
{
    public class CompanyRepository
    {
        public IEnumerable<VendorVm> All()
        {
            IEnumerable<Companies> companies;
            using var connection = DbHelper.GetNewSqlConnection();
            companies = connection.Query<Companies>(DbHelper.GetSelectAllSqlString("Companies"));
            
            foreach (var company in companies)
            {
                yield return CompaniesToCompanyVM(company);
            }
        }

        public VendorVm Find(int id)
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var company = connection.Query<Companies>(DbHelper.GetFindByColumnSqlString("Companies", "CompanyId", id.ToString()));
            return company.FirstOrDefault() != null ? CompaniesToCompanyVM(company.First()) :
                throw new KeyNotFoundException($"No item with id {id} found in table {nameof(Companies)}.");
        }

        public void Add(VendorVm companyVm)
        {
            Companies company = CompanyVmToCompanies(companyVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString("Companies", "Name", "Description", "Address", "Address2", 
                                                                "City", "State", "Zip", "Phone", "PhoneExtension", "Email");
            connection.ExecuteScalar(insertSqlCommand, company);
        }

        public void Remove(int Id)
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var deleteSqlCommand = DbHelper.GetSoftDeleteSqlString("Companies", "CompanyId", Id.ToString());

            connection.ExecuteScalar(deleteSqlCommand);
        }

        public void Update(VendorVm companyVm)
        {
            string updateSqlCommand = DbHelper.GetUpdateSqlString("Companies", "CompanyId", companyVm.CompanyId.ToString(), "Name",
                "Description", "Address", "Address2","City", "State", "Zip", "Phone", "PhoneExtension", "Email");

            using var connection = DbHelper.GetNewSqlConnection();
            connection.ExecuteScalar(updateSqlCommand, companyVm);
        }

        
        private VendorVm CompaniesToCompanyVM(Companies companies)
        {
            var companiesProperties = companies.GetType().GetProperties();
            var companyVmPropertyNames = typeof(VendorVm).GetProperties().Select(p => p.Name);
            VendorVm companyVm = new VendorVm();

            foreach (var property in companiesProperties)
            {
                if (companyVmPropertyNames.Contains(property.Name))
                    companyVm.GetType().GetProperty(property.Name).SetValue(companyVm, property.GetValue(companies));
            }

            return companyVm;
        }

        private Companies CompanyVmToCompanies(VendorVm companyVm)
        {
            var companyVmProperties = companyVm.GetType().GetProperties();
            Companies companies = new Companies();

            foreach (var property in companyVmProperties)
            {
                companies.GetType().GetProperty(property.Name).SetValue(companies, property.GetValue(companyVm));
            }

            return companies;
        }
    }
}
