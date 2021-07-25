using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace POS
{
    public static class DbHelper
    {
        private const string connString = "Data Source=DESKTOP-H775HQT\\SQLEXPRESS;Initial Catalog=POSDB;persist security info=True; Trusted_Connection=True";
        public static string GetConnectionString()
        {
            return connString;
        }

        public static IDbConnection GetNewSqlConnection() => new System.Data.SqlClient.SqlConnection(GetConnectionString());
        
        public static string GetUpdateSqlString(string tableName, string conditionColumnName, string conditionValue ,params string[] columns)
        {
            string sqlUpdateString = @$"update {tableName}
                                        set
                                        {(string.Join(",\r\n",columns.Select(p => p + " = " + "@" + p )))}
                                        where { conditionColumnName} = { conditionValue } ";
            return sqlUpdateString;
        }

        public static string GetSoftDeleteSqlString(string tableName, string conditionColumnName, string conditionValue)
        {
            string sqlSoftDeleteString = @$"update {tableName}
                                            set IsDeleted = 0
                                            where {conditionColumnName} = {conditionValue}";
            return sqlSoftDeleteString;
        }

        public static string GetInsertSqlString(string tableName, params string[] values)
        {
            string sqlInsertString = $@"insert into {tableName}({string.Join(", ", values)})
                                        values({string.Join(", ", values.Select(x => "@" + x))})";
            return sqlInsertString;
        }

        public static string GetSelectAllSqlString(string tableName)
        {
            return $"select * from {tableName} where IsDeleted = 0";
        }

        public static string GetFindByColumnSqlString(string tableName, string findByColumnName, string columnValue)
        {
            return $"select * from {tableName} where {findByColumnName} = {columnValue} and IsDeleted = 0";
        }
            
        
    }
}
