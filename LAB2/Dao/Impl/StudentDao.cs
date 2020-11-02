using System.Data;

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
    }
}