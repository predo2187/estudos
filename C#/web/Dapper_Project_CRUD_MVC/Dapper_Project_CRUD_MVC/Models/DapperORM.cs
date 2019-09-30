using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//adicionados
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace Dapper_Project_CRUD_MVC.Models
{
    public static class DapperORM
    {
        private static string connectionString = @"Data Source=INDNOTDEV001\SQLEXPRESS;Initial Catalog=DapperDb;User ID=sa;Password=jp19160518";

        //DapperORM ExecuteWithoutReturn, executa a edição e cadastro d eum funcionário por meio de uma procedure
        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);

            }
        }

        //DapperORM ExecuteWithoutReturnLocalQuery, executa a edição e cadastro de funcionário por meio da query local
        public static void ExecuteWithoutReturnLocalQuery(string comandoSql, DynamicParameters param)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            { 
                sqlCon.Open();
                sqlCon.Execute(comandoSql, param);

            }
        }

        //DapperORM ExecuteReturnScalar
        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.Execute(procedureName, param, commandType : CommandType.StoredProcedure), typeof(T));

            }
        }

        //DapperORM returnList<EmployeeModel>
        public static IEnumerable<T>ReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);

            }
        }
    }
}