using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Instructor
    {
        private static readonly Dictionary<int, Instructor> Data;

        static Instructor()
        {
            Data = InstructorDao.FetchAll().Select().Select(dr => new Instructor(Convert.ToInt32(dr["InstructorId"]),
                $@"{dr["InstructorFirstName"]} {dr["InstructorMidName"]} {dr["InstructorLastName"]}"
            )).ToDictionary(i => i.Id, i => i);
        }

        public int Id { get; set; }

        public string Name { get; set; }


        public Instructor(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public static List<Instructor> FetchAll()
        {
            return Data.Values.ToList();
        }

        public static Instructor Get(int id)
        {
            return Data.TryGetValue(id, out var res) ? res : null;
        }
    }
}