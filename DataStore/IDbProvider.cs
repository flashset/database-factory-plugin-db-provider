using System.Data; 

namespace DataStore
{
    public interface IDbProvider
    { 
        #region Connection          
        IDbConnection Connection(string connectionString);

        #endregion

        #region Command 

        IDbCommand Command(string cmdText, IDbConnection conn); 

        #endregion

        #region Adapter
         
        IDbDataAdapter DataAdapter(IDbCommand command); 

        #endregion
    }
}
