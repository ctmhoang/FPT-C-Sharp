using System.Data;
using System.Data.SqlClient;

namespace LAB2.Dao.impl
{
    public class StudentDao :BaseDao
    {
        public static DataTable FetchAll()
        {
            return FetchAll("Select * from STUDENTS");
        }

        public static DataTable GetAllStudentIdsBy(int courseId)
        {
            return FetchAll($"Select StudentId from Student_Course Where CourseId = {courseId}");
        }

        public static int Delete(SqlParameter studentId)
        {
            var command = new SqlCommand(@"Delete from student_course where studentid = @sId"){Parameters = { studentId}};
            return (int)ExecuteUpdate(command);
        }
    }
}