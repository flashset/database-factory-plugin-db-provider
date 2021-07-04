using DataStore;
using System.Data;
using System.Data.SqlClient;

namespace MSSqlProvider
{
    public class MSSQLConnector : IDbProvider
    { 
        #region Connection 

        public IDbConnection Connection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }

        #endregion

        #region Command

        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new SqlCommand(cmdText, (SqlConnection)conn);
        }

        #endregion

        #region DataAdapter

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new SqlDataAdapter((SqlCommand)command);
        }

        #endregion
    }
}
