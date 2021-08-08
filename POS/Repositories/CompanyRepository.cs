using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using POS.DbEntities;
using System.Linq;
using POS.ViewModels.Product;

namespace POS.Repositories
{
    public class CompanyRepository : BaseRepository<Companies, CompanyVm>
    {
        
        public void Update(CompanyVm companyVm)
        {
            string updateSqlCommand = DbHelper.GetUpdateSqlString("Companies", "CompanyId", companyVm.CompanyId.ToString(), "Name",
                "Description", "Address", "Address2", "City", "State", "Zip", "Phone", "PhoneExtension", "Email");

            using var connection = DbHelper.GetNewSqlConnection();
            connection.ExecuteScalar(updateSqlCommand, companyVm);
        }
        
    }
}
