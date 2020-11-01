
using System.Data;

namespace LAB2.Dao.impl
{
    public class CourseDao : BaseDao
    {
        public static DataTable FetchAll()
        {
            return FetchAll("SELECT * FROM COURSES");
        }
    }
}