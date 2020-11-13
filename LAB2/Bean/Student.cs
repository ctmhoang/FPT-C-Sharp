using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Student : IEquatable<Student>
    {
        private static readonly Dictionary<int, Student> Data;

        static Student()
        {
            Data = StudentDao.FetchAll().Select()
                .Select(dr => new Student($"{dr["FirstName"]} {dr["MidName"]} {dr["LastName"]}", dr["Roll#"].ToString(),
                    Convert.ToInt32(dr["StudentId"]))).ToDictionary(std => std.Id, std => std);
        }

        public static List<Student> FetchAll()
        {
            return Data.Values.ToList();
        }

        public static List<int> GetAllStudentIdsBy(int courseId)
        {
            return StudentDao.GetAllStudentIdsBy(courseId).Select().Select(dr => Convert.ToInt32(dr["StudentId"]))
                .ToList();
        }

        public static Student Get(int id)
        {
            return Data.TryGetValue(id, out var res) ? res : null;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public string RollId { get; set; }

        public Student(string name, string rollId, int id = 0)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            RollId = rollId ?? throw new ArgumentNullException(nameof(rollId));
            Id = id;
        }

        public bool Equals(Student other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name == other.Name && Id == other.Id && RollId == other.RollId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Student) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Id;
                hashCode = (hashCode * 397) ^ (RollId != null ? RollId.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static int Leave(int studentId, int courseId)
        {
            var param = new SqlParameter("sId", SqlDbType.Int) { Value = studentId };
            var param2 = new SqlParameter("cId",SqlDbType.Int){Value = courseId};
            return StudentDao.Leave(param,param2);
        }

        public static int LeaveRange(List<int> studIds, int courseId)
        {
            return studIds.Select(id => Leave(id ,courseId)).Sum();
        }

    }
}