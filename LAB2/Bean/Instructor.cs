using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DeptId { get; set; }

        public Instructor(int id, string name, int deptId)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            DeptId = deptId;
        }

        public static List<Instructor> FetchAll()
        {
            return InstructorDao.FetchAll().Select().Select(dr => new Instructor(Convert.ToInt32(dr["InstructorId"]),
                $@"{dr["InstructorFirstName"]} {dr["InstructorMidName"]} {dr["InstructorLastName"]}",
                Convert.ToInt32(dr["InstructorId"]))).ToList();
        }
    }
}
