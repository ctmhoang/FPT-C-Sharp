using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Winform.Business;

namespace Winform.Dao
{
    public static class OrderDataAccess
    {
        private static readonly string connString;

        static OrderDataAccess()
        {
            connString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }

        private static DataTable Select(string query)
        {
            using (var conn = GetConnection())
            using (var command = new SqlCommand(query, conn))
            {
                var adapter = new SqlDataAdapter(command);
                var ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }

        public static DataTable FetchAllCustomer()
        {
            const string query = @"select CustomerID, ContactName from Customers";
            return Select(query);
        }

        public static DataTable FetchAllEmployee()
        {
            const string query = @"Select CONCAT(FirstName, ' ', LastName) as Name, EmployeeID from Employees;";
            return Select(query);
        }

        public static DataTable FetchAllShippingComp()
        {
            const string query = @"select ShipperID, CompanyName from Shippers";
            return Select(query);
        }

        public static int ExecuteUpdate(string sql, params SqlParameter[] param)
        {
            using (var conn = GetConnection())
            using (var command = new SqlCommand(sql, conn))
            {
                command.Parameters.AddRange(param);
                conn.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static int insertOrder(Dictionary<Product, uint> cart, string cId, int eId, int dId, DateTime reqDate)
        {
            const string s1 =
                @"Insert into Orders (CustomerID, EmployeeID, OrderDate, RequiredDate, ShipVia) values (@cID, @eID, GETDATE(), @reqDate, @dId);";
            var p1 = new SqlParameter("@cID", SqlDbType.NVarChar) {Value = cId};
            var p2 = new SqlParameter("@eID", SqlDbType.Int) {Value = eId};
            var p4 = new SqlParameter("@dID", SqlDbType.Int) {Value = dId};
            var p3 = new SqlParameter("@reqDate", SqlDbType.DateTime) {Value = reqDate};

            var colParameters = new[]
            {
                ((ICloneable) p1).Clone(),
                ((ICloneable) p2).Clone(),
                ((ICloneable) p3).Clone(),
                ((ICloneable) p4).Clone()
            };

            ExecuteUpdate(s1, p1, p2, p3, p4);

            const string s2 = @"Select OrderID from Orders where CustomerID = @cID and EmployeeID = @eID and ShipVia = @dID and RequiredDate = @reqDate";
            int? oId;
            using (var conn = GetConnection())
            using (var command = new SqlCommand(s2, conn))
            {
                command.Parameters.AddRange(colParameters);
                conn.Open();
                oId = Convert.ToInt32(command.ExecuteScalar());
            }

            int orderId = oId ?? -1;
            if (orderId == -1) throw new IOException();

            const string sql3 =
                @"Insert into [Order details] (OrderID, ProductID, UnitPrice, Quantity) values (@oID, @pID, @price, @quan);";
            return cart.Select(entry => ExecuteUpdate(sql3, new SqlParameter("@oID", SqlDbType.Int) {Value = oId},
                new SqlParameter("@pID", SqlDbType.Int) {Value = entry.Key.Pid},
                new SqlParameter("@price", SqlDbType.Decimal) {Value = entry.Key.Price},
                new SqlParameter("quan", SqlDbType.SmallInt) {Value = entry.Value})).Sum();
        }
    }
}