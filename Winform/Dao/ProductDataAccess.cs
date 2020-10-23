using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Winform.Dao
{
    class ProductDataAccess
    {
        private static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
        }

        private static DataTable Select(string sql)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);
                return ds.Tables[0];
            }
        }

        public static DataTable FetchAllCategory()
        {
            string query = "Select CategoryID, CategoryName From Categories";
            return Select(query);
        }

        public static DataTable GetProductsByCategoryId(int categoryId)
        {
            string query = $"Select * from Products where CategoryID = {categoryId}";
            return Select(query);
        }

        public static DataTable FetchAllProducts()
        {
            string query = $"Select * from Products";
            return Select(query);
        }

        private static int ExecuteUpdate(string sql, params SqlParameter[] param)
        {
            using (var conn = GetConnection())
            using (var command = new SqlCommand(sql, conn))
            {
                command.Parameters.AddRange(param);
                conn.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static int EditProduct(int id, string name, decimal price)
        {

            string sql = @"update Products set ProductName = @name, UnitPrice = @price 
                        where ProductID = @id";
            var p1 = new SqlParameter("@id", SqlDbType.Int) {Value = id};
            var p2 = new SqlParameter("@name", SqlDbType.NVarChar) {Value = name};
            var p3 = new SqlParameter("@price", SqlDbType.Decimal) {Value = price};
            return ExecuteUpdate(sql, p1, p2, p3);
        }

        public static int InsertProduct(int cid, string name, decimal price)
        {
            string sql = @"Insert into Products (CategoryID, ProductName, UnitPrice) values (@cid , @name, @price)";
            var p1 = new SqlParameter("@cid", SqlDbType.Int) { Value = cid };
            var p2 = new SqlParameter("@name", SqlDbType.NVarChar) { Value = name };
            var p3 = new SqlParameter("@price", SqlDbType.Decimal) { Value = price };
            return ExecuteUpdate(sql, p1, p2, p3);
        }

        public static int DeleteProduct(int id)
        {
            string sql1 = "Delete from [Order Details] where ProductID = @id";
            var param1 = new SqlParameter("@id",SqlDbType.Int){Value = id};
            var param2 = ((ICloneable)param1).Clone() as SqlParameter;
            ExecuteUpdate(sql1, param1);
            string sql2 = "Delete from [Products] where ProductID = @id";
            return ExecuteUpdate(sql2, param2);
        }
    }
}