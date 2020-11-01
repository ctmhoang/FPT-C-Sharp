using System.Data;

namespace LAB2.Dao.impl
{
    public class SubjectDao : BaseDao
    {
        public static DataTable FetchAll()
        {
            return FetchAll("Select * from subjects");
        }
    }
}