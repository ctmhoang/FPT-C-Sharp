using System;
using System.Collections.Generic;
using System.Linq;
using LAB2.Dao.impl;

namespace LAB2.Bean
{
    public class Course
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public Subject Subject { get; set; }
        public Instructor Instructor { get; set; }

        public Course(string code, string description, Subject subject, Instructor instructor)
        {
            Code = code ?? throw new ArgumentNullException(nameof(code));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
            Instructor = instructor ?? throw new ArgumentNullException(nameof(instructor));
        }

        // public static List<Course> FetchAll()
        // {
        //     return CourseDao.FetchAll().Select().Select(dr => new Course(dr["CourseCode"].ToString(),
        //         dr["CourseDescription"].ToString(),
        //         Convert.ToInt32(dr["SubjectId"]), Convert.ToInt32(dr["InstructorId"]))).ToList();
        // }
    }
}