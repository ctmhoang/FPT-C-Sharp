using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Winform.Dao;

namespace Winform.Business
{
    public class Employee
    {
        public int Id { get; }
        public string FullName { get; }

        public Employee(int id, string fullName)
        {
            Id = id;
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        }

        public static List<Employee> FetchAll()
        {
            return OrderDataAccess.FetchAllEmployee().Select()
                .Select(dr => new Employee(Convert.ToInt32(dr["EmployeeID"]), dr["Name"].ToString())).ToList();
        }
    }
}