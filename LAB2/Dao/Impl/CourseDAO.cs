
using System;
using System.Data;
using System.Data.SqlClient;
using LAB2.Bean;

namespace LAB2.Dao.impl
{
    public class CourseDao : BaseDao
    {
        public static DataTable FetchAll()
        {
            return FetchAll("SELECT * FROM COURSES");
        }

        public static int Insert(params SqlParameter[] para)
        {
            var command =
                new SqlCommand(
                    @"Insert into Courses (CourseCode, CourseDescription, SubjectId, InstructorId)
                            output inserted.CourseId
                            values(@code, @des, @sId, @iId)");
            command.Parameters.AddRange(para);
            return (int)ExecuteUpdate(command, true);
        }

        public static int RegisterStudent(params SqlParameter[] para)
        {
            var command = new SqlCommand(@"Insert into Student_Course (CourseId, StudentId) values (@cId, @sId)");
            command.Parameters.AddRange(para);
            return (int) ExecuteUpdate(command);
        }

        public static void Delete(SqlParameter courseId)
        {
            var courseIdClone = ((ICloneable) courseId).Clone();
            var command = new SqlCommand(@"Delete from student_course where courseid = @cId");
            command.Parameters.Add(courseId);
            ExecuteUpdate(command);
            var command2 = new SqlCommand(@"Delete from courses where courseid = @cId");
            command2.Parameters.Add(courseIdClone);
            ExecuteUpdate(command2);
        }

    }
}