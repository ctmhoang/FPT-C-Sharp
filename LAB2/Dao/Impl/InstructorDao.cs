using System.Data;

namespace LAB2.Dao.impl
{
    public class InstructorDao : BaseDao
    {
        public static DataTable FetchAll()
        {
            return FetchAll("Select * from instructors");
        }
    }
}