using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Department
    {
        private static readonly Dictionary<int, string> Departments;

        static Department()
        {
            Departments = DepartmentDao.FetchAll().Select().Select(dr =>
                    new KeyValuePair<int, string>(Convert.ToInt32(dr["DepartmentId"]), dr["DepartmentName"].ToString()))
                .ToDictionary(pair => pair.Key, pair => pair.Value);
            ;
        }

        public static string Get(int id)
        {
            return Departments.TryGetValue(id, out var value) ? value : null;
        }
    }
}