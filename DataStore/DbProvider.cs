using System.Data; 

namespace DataStore
{
    public class DbProvider: IDbProvider
    {
        private IDbProvider _dbprovider;
        public DbProvider(IDbProvider operations)
        {
            _dbprovider = operations;
        } 

        #region Connection 

        public IDbConnection Connection(string connectionString)
        {
            return _dbprovider.Connection(connectionString);
        }

        #endregion

        #region Command
       
        public IDbCommand Command(string cmdText, IDbConnection conn)
        {
            return _dbprovider.Command(cmdText, conn);
        } 

        #endregion
          
        #region DataAdapter
         
        public IDbDataAdapter DataAdapter(IDbCommand command)
        {
            return _dbprovider.DataAdapter(command);
        } 

        #endregion
         
    }
}
