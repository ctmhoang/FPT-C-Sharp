using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Subject
    {
        private static readonly Dictionary<int, Subject> Data;

        static Subject()
        {
            Data = SubjectDao.FetchAll().Select().Select(dr => new Subject(Convert.ToInt32(dr["SubjectId"]),
                    dr["SubjectCode"].ToString(), dr["SubjectName"].ToString()))
                .ToDictionary(sub => sub.Id, sub => sub);
        }

        public static Subject Get(int id)
        {
            return Data.TryGetValue(id, out var res) ? res : null;
        }

        public static List<Subject> FetchAll()
        {
            return Data.Values.ToList();
        }

        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public Subject(int id, string code, string name)
        {
            Id = id;
            Code = code ?? throw new ArgumentNullException(nameof(code));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}