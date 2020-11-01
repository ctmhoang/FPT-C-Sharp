using System.Data;

namespace LAB2.Dao.impl
{
    public class DepartmentDao : BaseDao
    {
        public static DataTable FetchAll()
        {
            return FetchAll("select * from departments");
        }
    }
}