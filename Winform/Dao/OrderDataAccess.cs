using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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
            string query = @"select CustomerID, ContactName from Customers";
            return Select(query);
        }

        public static DataTable FetchAllEmployee()
        {
            string query = @"Select CONCAT(FirstName, ' ', LastName) as Name, EmployeeID from Employees;";
            return Select(query);
        }

        public static DataTable FetchAllShippingComp()
        {
            string query = @"select ShipperID, CompanyName from Shippers";
            return Select(query);
        }
    }
}