using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LAB2.Dao
{
    public abstract class BaseDao
    {
        private static readonly string ConnStr;

        static BaseDao()
        {
            ConnStr = ConfigurationManager.ConnectionStrings["blah"].ConnectionString;
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnStr);
        }

        protected static DataTable FetchAll(string query)
        {
            using (var conn = GetConnection())
            using (var command = new SqlCommand(query, conn))
            {
                var ds = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }

        protected static object ExecuteUpdate(SqlCommand command, bool isScalar = false)
        {
            using (var conn = GetConnection())
            {
                command.Connection = conn;
                conn.Open();
                return isScalar ? command.ExecuteScalar() : command.ExecuteNonQuery();
            }
        }
    }
}