using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Course
    {
        private static List<Course> Data;

        static Course()
        {
            Update();
        }

        public static void Update()
        {
            Data = CourseDao.FetchAll().Select().Select(dr => new Course(dr["CourseCode"].ToString(),
                dr["CourseDescription"].ToString(),
                Subject.Get(Convert.ToInt32(dr["SubjectId"])).Name,
                Instructor.Get(Convert.ToInt32(dr["InstructorId"])).Name,
                Convert.ToInt32(dr["CourseId"]))).ToList();
        }

        public static List<Course> FetchAll()
        {
            return Data.Select(c => c).ToList();
        }

        public static int Insert(string code, string des, int sid, int iid)
        {
            var param1 = new SqlParameter("code", SqlDbType.Text)
            {
                Value = code
            };
            var param2 = new SqlParameter("des", SqlDbType.Text)
            {
                Value = des
            };
            var param3 = new SqlParameter("sId", SqlDbType.Int)
            {
                Value = sid
            };
            var param4 = new SqlParameter("iId", SqlDbType.Int)
            {
                Value = iid
            };
            return CourseDao.Insert(param1, param2, param3, param4);
        }

        public static int RegisterStudentIn(int courseId, IEnumerable<Student> students)
        {
            return students.Select(s =>
                CourseDao.RegisterStudent(new SqlParameter("cId", SqlDbType.Int) {Value = courseId},
                    new SqlParameter("sId", SqlDbType.Int) {Value = s.Id})).Sum();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Sub { get; set; }
        public string Ins { get; set; }

        public Course(string code, string description, string subject, string instructor, int id = 0)
        {
            Id = id;
            Code = code ?? throw new ArgumentNullException(nameof(code));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Sub = subject ?? throw new ArgumentNullException(nameof(subject));
            Ins = instructor ?? throw new ArgumentNullException(nameof(instructor));
        }

        public static void Delete(Course course)
        {
            var param1 = new SqlParameter("cId",SqlDbType.Int){Value = course.Id};
            CourseDao.Delete(param1);
        }
    }
}