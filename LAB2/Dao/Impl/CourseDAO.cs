
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
    }
}