using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Subject
    {
        public int Id { get; set; }

        public int DeptId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public Subject(int id, int deptId, string code, string name)
        {
            Id = id;
            DeptId = deptId;
            Code = code ?? throw new ArgumentNullException(nameof(code));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public static List<Subject> FetchAll()
        {
            return SubjectDao.FetchAll().Select().Select(dr => new Subject(Convert.ToInt32(dr["SubjectId"]),
                    Convert.ToInt32(dr["DepartmentId"]), dr["SubjectCode"].ToString(), dr["SubjectName"].ToString()))
                .ToList();
        }
    }
}
