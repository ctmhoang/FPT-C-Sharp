using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Winform.Dao;

namespace Winform.Business
{
    public class Customer
    {
        public string Name { get; set; }
        public string Id { get; }

        public Customer(string name, string id)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public static List<Customer> FetchAll()
        {
            return OrderDataAccess.FetchAllCustomer().Select()
                .Select(dr => new Customer(dr["ContactName"].ToString(), dr["CustomerID"].ToString())).ToList();
        }
    }
}