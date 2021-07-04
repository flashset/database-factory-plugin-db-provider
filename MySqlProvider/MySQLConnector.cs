using DataStore;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlProvider
{
    public class MySQLConnector : IDbProvider
    {  
        #region Connection 

        public IDbConnection Connection(string connectionString)
        {
            return new MySqlConnection(connectionString);
        }

        #endregion

        #region Command

        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return new MySqlCommand(cmdText, (MySqlConnection)conn);
        }

        #endregion

        #region DataAdapter

        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return new MySqlDataAdapter((MySqlCommand)command);
        }

        #endregion
    }
}
